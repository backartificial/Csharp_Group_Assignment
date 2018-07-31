using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmAddCourse : Form {
        private frmCourses coursesForm;

        public frmAddCourse(frmCourses coursesForm) {
            InitializeComponent();

            this.coursesForm = coursesForm;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Add Course Form
            Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e) {
            // Perform Add Course
            addCourse();
        }

        private void btnAddAnotherCourse_Click(object sender, EventArgs e) {
            // Perform Add Course
            addCourse();
        }

        private void addCourse() {
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

                            // Perform blank return to not process any more of this function
                            return;
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
                            }
                        }
                    }

                    // Close the DB connection
                    connection.Close();
                }

                // Refresh the DataGrid on the Courses form
                coursesForm.coursesTableAdapter.Fill(coursesForm.studentManagerDBDataSet.Courses);
                coursesForm.dgvCourses.Refresh();
                coursesForm.dgvCourses.Parent.Refresh();

                // Close the form
                Close();
            }
        }
    }
}
