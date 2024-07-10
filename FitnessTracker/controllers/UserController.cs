using FitnessTracker.helpers;
using static FitnessTracker.services.UserService;


namespace FintnessTracker.controllers
{
    internal class UserController
    {
        public bool Login(string username, string password)
        {
            return AuthenticateUser(username, password);
        }

        public bool Register(string username, string password, double weight, double height)
        {
            string HashedPassword = Hasher.Hash(password);
            return RegisterUser(username, HashedPassword, weight, height);
        }

        public void Logout()
        {
            LogoutUser();
        }
    }
}
