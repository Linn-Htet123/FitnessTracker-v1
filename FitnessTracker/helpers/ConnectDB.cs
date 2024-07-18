using MySql.Data.MySqlClient;
using System;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.helpers
{
    internal class ConnectDB
    {
        public string CONNECTION_STRING { get; private set; }
        public MySqlConnection CONN { get; private set; }
        private readonly Env env;

        public ConnectDB()
        {
            try
            {
                env = new Env();
                CONNECTION_STRING = $"server={env.DatabaseServer};username={env.Username};password={env.Password};database={env.DatabaseName}";
                CONN = new MySqlConnection(CONNECTION_STRING); // Initializes the MySqlConnection with the connection string
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error.ToString()); // Logs the error to the console
                ErrorPopup($"Connection fails: {error.Message}"); // Displays an error popup with the error message
            }
        }

        public void OpenConnection()
        {
            if (CONN.State == System.Data.ConnectionState.Closed) // Checks if the connection is closed
            {
                try
                {
                    CONN.Open(); // Opens the database connection
                }
                catch (Exception err)
                {
                    ErrorPopup($"Database connection error has occurred: {err.Message}"); // Displays an error popup if the connection fails
                }
            }
        }

        public void CloseConnection()
        {
            if (CONN.State == System.Data.ConnectionState.Open) // Checks if the connection is open
            {
                CONN.Close(); // Closes the database connection
            }
        }
    }
}
