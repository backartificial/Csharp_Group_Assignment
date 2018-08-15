using System;
using System.Data.SqlClient;

namespace DatabaseService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Database" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Database.svc or Database.svc.cs at the Solution Explorer and start debugging.
    public class Database : IDatabase {
        // Create class variables
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString.ToString().Replace("\\\\", "\\"));

        /**
         * 
         * This function is used to open the connection to the database
         * 
         **/
        private void Connect() {
            // Open the connection to the database
            connection.Open();
        }

        /**
         * 
         * This function is used to close a connection to the database
         * 
         **/
        private void Disconnect() {
            // Close the connection to the database
            connection.Close();
        }

        /**Method that checks if a course code is unique. 
		 * @param - courseCode - the course code that is to be checked for uniqueness
		 * Returns true if the course code is unique, false if it isn't.
		**/
        public bool checkUniqueCourse(string courseCode) {
            Int32 count;
            Connect();
            SqlCommand command;
            using (command = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE courseCode = @courseCode", connection)) {
                command.Parameters.AddWithValue("@courseCode", courseCode);
                count = (Int32)command.ExecuteScalar();

                Disconnect();

                // If the course code is already in use return false
                if (count > 0) {
                    return false;
                }

                return true;
            }
        }

        /**Method that checks if a program name is unique. 
		 * @param - programName - the program name that is to be checked for uniqueness
		 * Returns true if the program name is unique, false if it isn't.
		**/
        public bool checkUniqueProgram(string programName) {
            Int32 count;
            Connect();
            SqlCommand command;
            using (command = new SqlCommand("SELECT COUNT(*) FROM Program WHERE name = @progName", connection)) {
                command.Parameters.AddWithValue("@progName", programName);
                count = (Int32)command.ExecuteScalar();

                Disconnect();

                // If the course code is already in use return false
                if (count > 0) {
                    return false;
                }

                return true;
            }
        }
    }
}
