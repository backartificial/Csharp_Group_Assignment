using System;
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

        private dynamic select(string table, string query, Dictionary<string, string> attributes) {
            List<dynamic> items = new List<dynamic>();

            using(SqlCommand command = new SqlCommand(query, connection)) {
                foreach(var item in attributes) {
                    command.Parameters.AddWithValue("@" + item.Key, item.Value);
                }

                // Using the reader, perform the reading of data
                using(SqlDataReader reader = command.ExecuteReader()) {
                    // Loop through each returned item and add it to the list
                    while(reader.Read()) {
                        // Append the selected items to the list based on type
                        items.Add(new Course(1, "", "", "", DateTime.Parse(""), 1, 1));
                    }
                }
            }

            return items;
        }

        private int count(SqlCommand command) {
            // Based on the query string, get the amount of returned rows
            return int.Parse(command.ExecuteScalar().ToString());
        }





        public Course getCourse(int id) {
            return select("Course", "", new Dictionary<string, string> { { "id", id.ToString() } });
        }

        public Course getCourse(string courseCode) {
            // Select based on courseCode

            return new Course(1, "", "", "", DateTime.Parse(""), 1, 1);
        }

    }
}
