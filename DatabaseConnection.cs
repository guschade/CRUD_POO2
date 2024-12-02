using MySql.Data.MySqlClient;

namespace trabalhoB2
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;
        private static readonly object padlock = new object();
        public MySqlConnection Connection { get; private set; }

        DatabaseConnection()
        {
            string connectionString = "server=localhost;database=RestauranteDB;uid=user;pwd=password;SslMode=None;";
            Connection = new MySqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                    return instance;
                }
            }
        }
    }
}
