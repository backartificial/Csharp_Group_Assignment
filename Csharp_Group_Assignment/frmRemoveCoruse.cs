using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmRemoveCoruse : Form {
        private Course course;
        private frmCourses coursesForm;

        public frmRemoveCoruse(Course course, frmCourses frmCourse) {
            InitializeComponent();

            this.course = course;
            this.coursesForm = frmCourse;
        }

        private void lblDiagree_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        private void lblAgree_Click(object sender, EventArgs e) {
            // Remove the Course children from the Database
            using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                // Open the DB connection
                connection.Open();

                // Remove From ProgramCoruse
                using(SqlCommand command = new SqlCommand("DELETE FROM courseprogram WHERE courseid = @courseId", connection)) {
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Remove from ProfessorCourse
                using(SqlCommand command = new SqlCommand("DELETE FROM professorcourse WHERE courseid = @courseId", connection)) {
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Remove from StudentCourse
                using(SqlCommand command = new SqlCommand("DELETE FROM studentcourse WHERE courseid = @courseId", connection)) {
                    command.Parameters.AddWithValue("@courseId", course.id);
                    command.ExecuteNonQuery();
                }

                // Remove the Course Parent
                using(SqlCommand command = new SqlCommand("DELETE FROM courses WHERE id = @courseId", connection)) {
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
