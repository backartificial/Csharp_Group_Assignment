/**
 * 
 * File: frmRemoveCourse.cs
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

namespace Csharp_Group_Assignment {
    public partial class frmRemoveCoruse : Form {
        private Course course;
        private frmCourses coursesForm;

        /**
         * 
         * This meethod is used to initialize the component and set the class variables
         * 
         * @param course: is the course to be removed
         * @param frmCourse: is the courses form that is passed in so that modifications can be made to it
         * 
         **/
        public frmRemoveCoruse(Course course, frmCourses frmCourse) {
            // Initialize the component
            InitializeComponent();

            // Set the class variables
            this.course = course;
            this.coursesForm = frmCourse;
        }

        /**
         * 
         * This function is used when the course doesn't want to remove the course; it closes the form
         * 
         **/
        private void lblDiagree_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        /**
         * 
         * This function is used to remove the course once the user accepts the removal of the course
         * 
         **/
        private void lblAgree_Click(object sender, EventArgs e) {
            // Remove the Course children from the Database
            using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                // Open the DB connection
                connection.Open();

                // Remove From ProgramCoruse
                using(SqlCommand command = new SqlCommand("DELETE FROM courseprogram WHERE courseid = @courseId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Remove from ProfessorCourse
                using(SqlCommand command = new SqlCommand("DELETE FROM professorcourse WHERE courseid = @courseId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Remove from StudentCourse
                using(SqlCommand command = new SqlCommand("DELETE FROM studentcourse WHERE courseid = @courseId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Remove the Course Parent
                using(SqlCommand command = new SqlCommand("DELETE FROM courses WHERE id = @courseId", connection)) {
                    // Append the needed parameters and then execute the deletion
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
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
