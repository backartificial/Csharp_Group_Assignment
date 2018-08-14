/**
 * 
 * File: frmAddPrograms.cs
 * Developer: Emily Ramanna
 * Student Number: 991430310
 * Date: August 11, 2018
 * Description: Form to aid user add a new Program.
 * 
 **/

// Include needed packages
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for this form
    public partial class frmAddPrograms : Form {

        // Declare needed variables
        private frmPrograms programsForm; //Form that was used to open this form

        /**
         * 
         * This function is used to initialixe this component
         * 
         * @param progFrm: is the program form that is being passed in so that it can be manipulated
         * 
         **/
        public frmAddPrograms(frmPrograms progFrm) {
            // Initialize component
            InitializeComponent();

            // Set the form variable
            this.programsForm = progFrm;
        }

        /**
         * 
         * This function is used to cancel and close this form
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Add Program Form
            Close();
        }


        /**
         * 
         * This function is used to call the add program function and then close the form
         * 
         **/
        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            // Perform Add Program and check if it was successful
            if (addProgram())
            {
                // Close the form
                Close();
            }
        }

        
        /**
         * 
         * This fucntion is used to call the add program function and then clear the form to allow user to add another program
         * 
         **/
        private void btnAddAnotherProgram_Click(object sender, EventArgs e)
        {
            // Perform Add Program
            if (addProgram())
            {
                // Clear the form 
                txtProgramName.Text = "";
                txtProgramOutcome.Text = "";
                nudDuration.Value = 0;
                chkbxCoop.Checked = false;

                // Sets the focus
                txtProgramName.Focus();
            }
        }

       
        /**
         * 
         * This function is used to add the program into the database and then refresh the datagrid view on form frmPrograms
         * 
         * @return Boolean: true - addedd successfully | false - if program not addedd successfully
         * 
         **/
        private Boolean addProgram()
        {
            // Check if the user added all items in the form
            if (txtProgramName.Text.Trim().Equals("") || txtProgramOutcome.Text.Trim().Equals("") || nudDuration.Value == 0)
            {
                // Display error message
                MessageBox.Show("Oops... Not all fields were filled in.  Please fill in all fields and try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Add the user into the database
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString))
                {
                    // Open the DB connection
                    connection.Open();

                    // Set the SqlCommand
                    SqlCommand command;

                    // Check if the program name is in use
                    using (command = new SqlCommand("SELECT COUNT(*) FROM program WHERE name = @progName", connection))
                    {
                        command.Parameters.AddWithValue("@progName", txtProgramName.Text);
                        Int32 count = (Int32)command.ExecuteScalar();

                        // If the program name is in use display a message
                        if (count > 0)
                        {
                            // Display Error Message
                            MessageBox.Show("Oops... Look like the Program Name that you entered is already in use. Please enter another Program Name and try again!", "Program Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Close the DB connection
                            connection.Close();

                            // Focus on the program name field
                            txtProgramName.Focus();
                        }
                        else
                        {
                            // Add the program
                            using (command = new SqlCommand("INSERT INTO program (name, duration, coop, outcome) VALUES (@progName, @dur, @coop, @outcome)", connection))
                            {
                                command.Parameters.AddWithValue("@progName", txtProgramName.Text);
                                command.Parameters.AddWithValue("@dur", nudDuration.Value.ToString());

                                //determines if the program has the coop option
                                if (chkbxCoop.Checked)
                                {
                                    command.Parameters.AddWithValue("@coop", '1');
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@coop", '0');
                                }

                                command.Parameters.AddWithValue("@outcome", txtProgramOutcome.Text);

                                command.ExecuteNonQuery();

                                // Refresh the DataGrid on the Programs form
                                programsForm.programTableAdapter.Fill(programsForm.dtsAllData.Program);
                                programsForm.dgvPrograms.Refresh();
                                programsForm.dgvPrograms.Parent.Refresh();

                                // Close the DB connection
                                connection.Close();

                                // Return successful
                                return true;
                            }
                        }
                    }
                }
            }

            // Perform blank return to not process any more of this function
            return false;
        }
    }
}
