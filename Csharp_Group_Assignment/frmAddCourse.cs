/**
 * 
 * File: frmAddCourse.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 11, 2018
 * 
 * 
 **/

// Include needed packages
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for this form
    public partial class frmAddCourse : Form {
        // Declare needed variables
        private frmCourses coursesForm;

        /**
         * 
         * This function is used to initialise this component
         * 
         * @param coursesForm: is the course form that is being passed in so that it can be manipulated
         * 
         **/
        public frmAddCourse(frmCourses coursesForm) {
            // Initialize component
            InitializeComponent();

            // Set the form variable
            this.coursesForm = coursesForm;
        }

        /**
         * 
         * This function is used to cancel and close this form
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Add Course Form
            Close();
        }


        /**
         * 
         * This function is used to call the add course function and then close the form
         * 
         **/
        private void btnAddCourse_Click(object sender, EventArgs e) {
            // Perform Add Course and check if it was successful
            if(addCourse()) {
                // Close the form
                Close();
            }
        }

        /**
         * 
         * This fucntion is used to call the add course function and then clear the form to allow user to add another course
         * 
         **/
        private void btnAddAnotherCourse_Click(object sender, EventArgs e) {
            // Perform Add Course
            if(addCourse()) {
                // Clear the form and focus to course code
                txtCourseCode.Text = "";
                txtCourseName.Text = "";
                txtLocation.Text = "";
                dtpTime.Value = DateTime.Now;
                nudCapacity.Value = 0;
                nudCredits.Value = 0;

                // Set the focus to the capacity
                txtCourseCode.Focus();
            }
        }

        /**
         * 
         * This function is used to add the course into the database and then refresh the datagrid view on form frmCourse
         * 
         * @return Boolean: true - addedd successfully | false - if course not addedd successfully
         * 
         **/
        private Boolean addCourse() {
            // Check if the user added all items in the form
            if (txtCourseCode.Text.Trim().Equals("") || txtCourseName.Text.Trim().Equals("") || txtLocation.Text.Trim().Equals("") || dtpTime.Text.Trim().Equals("") || nudCapacity.Value == 0 || nudCredits.Value == 0) {
                // Display error message
                MessageBox.Show("Oops... Not all fields were filled in.  Please fill in all fields and try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                // Add the user into the database
                using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                    // Open the DB connection
                    connection.Open();

                    // Set the SqlCommand
                    SqlCommand command;

                    // Check if the course Code is is use
                    using(command = new SqlCommand("SELECT COUNT(*) FROM courses WHERE coursecode = @courseCode", connection)) {
                        command.Parameters.AddWithValue("@courseCode", txtCourseCode.Text);
                        Int32 count = (Int32)command.ExecuteScalar();

                        // Check if the courseCode is in use
                        if(count > 0) {
                            // Display Error Message
                            MessageBox.Show("Oops... Look like the Course Code that you entered is already in use. Please enter another Course Code and try again!", "Course Code Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Close the DB connection
                            connection.Close();

                            // Focus on the courseCode field
                            txtCourseCode.Focus();
                        } else{
                            // Add the course
                            using(command = new SqlCommand("INSERT INTO courses (courseCode, name, location, time, capacity, credits) VALUES (@courseCode, @name, @location, @time, @capacity, @credits)", connection)) {
                                command.Parameters.AddWithValue("@courseCode", txtCourseCode.Text);
                                command.Parameters.AddWithValue("@name", txtCourseName.Text);
                                command.Parameters.AddWithValue("@location", txtLocation.Text);
                                command.Parameters.AddWithValue("@time", dtpTime.Value.ToString());
                                command.Parameters.AddWithValue("@capacity", nudCapacity.Value.ToString());
                                command.Parameters.AddWithValue("@credits", nudCredits.Value.ToString());
                                command.ExecuteNonQuery();

                                // Refresh the DataGrid on the Courses form
                                coursesForm.coursesTableAdapter.Fill(coursesForm.dtsAllData.Courses);
                                coursesForm.dgvCourses.Refresh();
                                coursesForm.dgvCourses.Parent.Refresh();

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
