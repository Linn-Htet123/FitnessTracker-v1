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

                var newUser = new User(userId, username, weight, height, 0);
                newUser.Authenticate();
                StoreServices.SetState(newUser, "CurrentUser");

                return newUser.IsAuthenticated;
            });
        }


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
                            var user = new User(
                                Convert.ToInt32(reader["id"]),
                                reader["username"].ToString(),
                                Convert.ToDouble(reader["weight"]),
                                Convert.ToDouble(reader["height"]),
                                Convert.ToDouble(reader["total_calories_burned"])
                                );

                            user.Authenticate();
                            StoreServices.SetState(user, "CurrentUser");
                            return user.IsAuthenticated;
                        }
                    }
                }
                return false;
            });
        }

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
