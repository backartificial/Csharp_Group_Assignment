/**
 * 
 * File: frmEditCourse.cs
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
    public partial class frmEditCourse : Form {
        // Declare needed variables
        private Course course;
        private frmCourses coursesForm;

        /**
         * 
         * This function is used to initialize this form
         * 
         * @param course: is the course to edit
         * @param coursesForm: is the course for that is passed so that modifications can be made to it
         * 
         **/
        public frmEditCourse(Course course, frmCourses coursesForm) {
            // Initialize the component
            InitializeComponent();

            // Set the class variables
            this.course = course;
            this.coursesForm = coursesForm;
        }

        /**
         * 
         * This function is used to calcel and close this form
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Form
            Close();
        }

        /**
         * 
         * This form is used to load the form
         * 
         **/
        private void frmEditCourse_Load(object sender, EventArgs e) {
            // Set the form items to the course being edited items
            txtCourseCode.Text = course.courseCode.ToString();
            txtCourseName.Text = course.name.ToString();
            txtLocation.Text = course.location.ToString();
            dtpTime.Value = DateTime.Parse(course.time.ToString());
            nudCapacity.Value = course.capacity;
            nudCredits.Value = course.credits;
        }

        /**
         * 
         * This form is used when the user decides to edit the course, it perform the db edit and then also updated the datagridview on the courses form
         * 
         **/
        private void btnEditCourse_Click(object sender, EventArgs e) {
            // Edit the course in the Database
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                // Open the DB connection
                connection.Open();

                // Update the course
                using (SqlCommand command = new SqlCommand("UPDATE courses SET name = @name, location = @location, time = @time, capacity = @capacity, credits = @credits WHERE id = @courseId", connection)) {
                    command.Parameters.AddWithValue("@name", txtCourseName.Text);
                    command.Parameters.AddWithValue("@location", txtLocation.Text);
                    command.Parameters.AddWithValue("@time", dtpTime.Value.ToString());
                    command.Parameters.AddWithValue("@capacity", nudCapacity.Value.ToString());
                    command.Parameters.AddWithValue("@credits", nudCredits.Value.ToString());
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Close the DB connection
                connection.Close();
            }

            // Refresh the DataGrid on the Courses form
            coursesForm.coursesTableAdapter.Fill(coursesForm.dtsAllData.Courses);
            coursesForm.dgvCourses.Refresh();
            coursesForm.dgvCourses.Parent.Refresh();

            // Close the form
            Close();
        }
    }
}
