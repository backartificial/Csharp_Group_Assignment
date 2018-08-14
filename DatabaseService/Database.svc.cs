using Csharp_Group_Assignment;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Database" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Database.svc or Database.svc.cs at the Solution Explorer and start debugging.
    public class Database : IDatabase {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString);

        private void Connect() {
            // Open the connection to the database
            connection.Open();
        }

        private void Disconnect() {
            // Close the connection to the database
            connection.Close();
        }

        public Course checkUnique(string id) {
            //return select("Course", "", new Dictionary<string, string> { { "id", id.ToString() } });
        }
    }
}
