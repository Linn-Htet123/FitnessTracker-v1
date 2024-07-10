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
                CONN = new MySqlConnection(CONNECTION_STRING);
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error.ToString());
                ErrorPopup($"Connection fails: {error.Message}");
            }
        }

        public void OpenConnection()
        {
            if (CONN.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    CONN.Open();
                }
                catch (Exception err)
                {
                    ErrorPopup($"Database connection error has occurred: {err.Message}");
                }
            }
        }

        public void CloseConnection()
        {
            if (CONN.State == System.Data.ConnectionState.Open)
            {
                CONN.Close();
            }
        }
    }
}
