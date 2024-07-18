using FitnessTracker.helpers;
using static FitnessTracker.services.UserService;

namespace FitnessTracker.controllers
{
    internal class UserController
    {
        public bool Login(string username, string password)
        {
            return AuthenticateUser(username, password); // Authenticates the user with the given username and password
        }

        public bool Register(string username, string password, double weight, double height)
        {
            string HashedPassword = Hasher.Hash(password); // Hashes the user's password before storing it
            return RegisterUser(username, HashedPassword, weight, height); // Registers a new user with the given details
        }

        public bool UpdateWeightAndHeight(double weight, double height)
        {
            return UpdateUserWeightAndHeight(weight, height); // Updates the user's weight and height
        }

        public void Logout()
        {
            LogoutUser(); // Logs out the current user
        }
    }
}
