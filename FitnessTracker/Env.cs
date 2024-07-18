using System.Configuration;
namespace FitnessTracker
{
    public class Env
    {
        public string DatabaseServer { get; private set; }
        public string DatabaseName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string ProjectName { get; private set; }

        // Constructor to initialize environment variables
        public Env()
        {
            // getting from App.config file
            DatabaseServer = ConfigurationManager.AppSettings["DatabaseServer"];
            DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
            Username = ConfigurationManager.AppSettings["Username"];
            Password = ConfigurationManager.AppSettings["Password"];
            ProjectName = ConfigurationManager.AppSettings["ProjectName"];
        }
    }
}
