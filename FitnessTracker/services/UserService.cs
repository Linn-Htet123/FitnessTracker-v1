using FitnessTracker.enums;
using FitnessTracker.helpers;
using FitnessTracker.models;
using System;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.services
{
    internal static class UserService
    {
        private static readonly string UsersTable = Tables.Users.ToTableName();

        // Check if a username already exists in the database
        public static bool IsUsernameExists(string username)
        {
            return ErrorHandling.HandleError(() =>
            {
                var conditions = new (string columnName, object columnValue)[]
                {
                    ("username", username),
                };

                using (var reader = QueryBuilder.Read(UsersTable, conditions: conditions))
                {
                    return reader.HasRows;
                }
            });
        }

        // Register a new user with the given username, password, weight, and height
        public static bool RegisterUser(string username, string password, double weight, double height)
        {
            return ErrorHandling.HandleError(() =>
            {
                if (IsUsernameExists(username))
                {
                    WarningPopup("Username already exists");
                    return false;
                }

                var values = new (string columnName, object columnValue)[]
                {
                    ("username", username),
                    ("password", password),
                    ("weight", weight),
                    ("height", height)
                };

                int userId = QueryBuilder.Insert(UsersTable, values);
                if (userId <= 0)
                {
                    WarningPopup("Failed to register user");
                    return false;
                }

                // Create a new User instance and authenticate it
                var newUser = new User(userId, username, weight, height, 0);
                newUser.Authenticate();

                // Store the current user in application state
                StoreServices.SetState(newUser, "CurrentUser");

                return newUser.IsAuthenticated;
            });
        }

        // Authenticate a user with the given username and password
        public static bool AuthenticateUser(string username, string password)
        {
            return ErrorHandling.HandleError(() =>
            {
                var conditions = new (string columnName, object columnValue)[]
                {
                    ("username", username),
                };

                using (var reader = QueryBuilder.Read(UsersTable, conditions: conditions))
                {
                    if (reader.Read())
                    {
                        string storedHash = reader["password"].ToString();
                        if (Hasher.Verify(password, storedHash))
                        {
                            // Create a User instance and authenticate it
                            var user = new User(
                                Convert.ToInt32(reader["id"]),
                                reader["username"].ToString(),
                                Convert.ToDouble(reader["weight"]),
                                Convert.ToDouble(reader["height"]),
                                Convert.ToDouble(reader["total_calories_burned"])
                            );

                            user.Authenticate();

                            // Store the current user in application state
                            StoreServices.SetState(user, "CurrentUser");

                            return user.IsAuthenticated;
                        }
                    }
                }
                return false;
            });
        }

        // Update the weight and height of the current user
        public static bool UpdateUserWeightAndHeight(double newWeight, double newHeight)
        {
            return ErrorHandling.HandleError(() =>
            {
                var currentUser = StoreServices.GetState<User>("CurrentUser");
                var conditions = new (string columnName, object columnValue)[]
                {
                    ("id", currentUser.UserId),
                };

                var updates = new (string columnName, object columnValue)[]
                {
                    ("weight", newWeight),
                    ("height", newHeight),
                };

                int rowsAffected = QueryBuilder.Update(UsersTable, updates, conditions);
                if (rowsAffected <= 0)
                {
                    return false;
                }

                // Update the current user's state if the update is successful
                var updatedUser = new User(currentUser.UserId, currentUser.Username, newWeight, newHeight, 0);
                StoreServices.SetState(updatedUser, "CurrentUser");

                return true;
            });
        }

        // Logout the current user by clearing their state from application state
        public static void LogoutUser()
        {
            ErrorHandling.HandleError(() =>
            {
                // Clear the current user from application state on logout
                StoreServices.ClearState("CurrentUser");
            });
        }
    }
}
