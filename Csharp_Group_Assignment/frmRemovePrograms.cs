/**
 * 
 * File: frmRemovePrograms.cs
 * Developer: Emily Ramanna
 * Student Number: 991430310
 * Date: August 11, 2018
 * Description: Form to aid a user to delete a program.
 * 
 **/

// Include needed packages
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmRemovePrograms : Form {

        private Programs program; //program to be deleted
        private frmPrograms progFrm; //the form that was used to open this form

        /**
         * 
         * This meethod is used to initialize the component and set the class variables
         * 
         * @param program: is the program to be removed
         * @param frmProg: is the programs form that is passed in so that modifications can be made to it
         * 
         **/
        public frmRemovePrograms(Programs program, frmPrograms frmProg) {
            // Initialize the component
            InitializeComponent();

            // Set the class variables
            this.program = program;
            this.progFrm = frmProg;
        }

        /**
         * 
         * This function is used when the user doesn't want to remove the program; it closes the form
         * 
         **/
        private void lblDiagree_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        /**
         * 
         * This function is used to remove the program once the user accepts
         * 
         **/
        private void lblAgree_Click(object sender, EventArgs e) {
            // Remove the Program children from the Database first
            using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                // Open the DB connection
                connection.Open();

                // Remove From CourseProgram
                using(SqlCommand command = new SqlCommand("DELETE FROM courseprogram WHERE programid = @progId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@progId", program.id);
                    command.ExecuteNonQuery();
                }

                // Remove from StudentProgram
                using(SqlCommand command = new SqlCommand("DELETE FROM studentprogram WHERE programid = @progId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@progId", program.id);
                    command.ExecuteNonQuery();
                }

                // Remove the Program Parent
                using(SqlCommand command = new SqlCommand("DELETE FROM program WHERE id = @progId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@progId", program.id);
                    command.ExecuteNonQuery();
                }

                // Close the DB connection
                connection.Close();
            }

            // Refresh the DataGrid on the Programs form
            progFrm.programTableAdapter.Fill(progFrm.dtsAllData.Program);
            progFrm.dgvPrograms.Refresh();
            progFrm.dgvPrograms.Parent.Refresh();

            // Close the form
            Close();
        }
    }
}
