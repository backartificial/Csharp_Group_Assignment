/**
 * 
 * File: frmEditPrograms.cs
 * Developer: Emily Ramanna
 * Student Number: 991430310
 * Date: August 11, 2018
 * Description: Form to aid the user in editing a program's information
 * 
 **/

// Include needed packages
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {

    // This is the class for this form
    public partial class frmEditPrograms : Form {
        // Declare needed variables
        private Programs program; //Program that is to be edited
        private frmPrograms progFrm; //Form that will be manipulated

        /**
         * 
         * This function is used to initialize this form
         * 
         * @param program: is the program to edit
         * @param progForm: is the programs form that is passed so that modifications can be made to it
         * 
         **/
        public frmEditPrograms(Programs program, frmPrograms progForm) {
            // Initialize the component
            InitializeComponent();

            // Set the class variables
            this.program = program;
            this.progFrm = progForm;
        }

        /**
         * 
         * This function is used to cancel and close this form
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Form
            Close();
        }

        /**
         * 
         * This function is used to load the form
         * 
         **/

        private void frmEditProgram_Load(object sender, EventArgs e)
        {
            // Set the form items to the program's existing values
            txtProgramName.Text = program.name.ToString();
            nudDuration.Value = program.duration;
            if (program.coop.Equals('1'))
            {
                chkbxCoop.Checked = true;
            }
            else
            {
                chkbxCoop.Checked = false;
            }
            txtOutcome.Text = program.outcome.ToString();
        }

        /**
         * 
         * This function is used when the user decides to edit a program, it performs
         * the db edit and then also updated the datagridview on the programs form.
         * 
         **/
        private void btnEditProgram_Click(object sender, EventArgs e)
        {
            // Edit the program in the Database
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString))
            {
                // Open the DB connection
                connection.Open();

                // Update the program
                using (SqlCommand command = new SqlCommand("UPDATE program SET duration = @dur, coop = @coop, outcome = @outcome WHERE id = @progId", connection))
                {
                    command.Parameters.AddWithValue("@dur", nudDuration.Value.ToString());
                    if (chkbxCoop.Checked)
                    {
                        command.Parameters.AddWithValue("@coop", '1');
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@coop", '0');
                    }
                    command.Parameters.AddWithValue("@outcome", txtOutcome.Text);
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
