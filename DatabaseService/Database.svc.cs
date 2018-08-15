using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Database" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Database.svc or Database.svc.cs at the Solution Explorer and start debugging.
    public class Database : IDatabase
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString);

        private void Connect()
        {
            // Open the connection to the database
            connection.Open();
        }

        private void Disconnect()
        {
            // Close the connection to the database
            connection.Close();
        }

        public bool checkUniqueCourse(string courseCode)
        {
            Int32 count;
            Connect();
            SqlCommand command;
            using (command = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE courseCode = @courseCode", connection))
            {
                command.Parameters.AddWithValue("@courseCode", courseCode);
                count = (Int32)command.ExecuteScalar();

                Disconnect();

                // If the course code is already in use return false
                if (count > 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool checkUniqueProgram(string programName)
        {
            Int32 count;
            Connect();
            SqlCommand command;
            using (command = new SqlCommand("SELECT COUNT(*) FROM Program WHERE name = @progName", connection))
            {
                command.Parameters.AddWithValue("@progName", programName);
                count = (Int32)command.ExecuteScalar();

                Disconnect();

                // If the course code is already in use return false
                if (count > 0)
                {
                    return false;
                }

                return true;
            }
        }

        public Data PullData(string table) {
            Connect();

            var data = new Data { Value = new List<Dictionary<string, string>>() };

            using (var command = new SqlCommand("SELECT * FROM" + table, connection)) {
                using (var reader = command.ExecuteReader()) {
                    var row = new Dictionary<string, string>();
                    while (reader.Read()) {
                        for (var index = 0; index < reader.FieldCount; index++) {
                            row.Add(reader.GetName(index), reader.GetString(index));
                        }

                        data.Value.Add(row);
                    }
                }
            }

            Disconnect();

            return data;
        }

        public bool PushData(string query) {
            try {
                Connect();

                SqlCommand statement = new SqlCommand(query, connection);

                statement.ExecuteNonQuery();

                statement.Dispose();

                Disconnect();
            } catch (SqlException ex) {
                return false;
            }

            return true;
        }
    }
}
