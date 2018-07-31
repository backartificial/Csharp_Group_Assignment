using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmEditCourse : Form {
        private Course course;
        private frmCourses coursesForm;


        public frmEditCourse(Course course, frmCourses coursesForm) {
            InitializeComponent();

            this.course = course;
            this.coursesForm = coursesForm;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Form
            Close();
        }

        private void frmEditCourse_Load(object sender, EventArgs e) {
            // Set the form items to the course being edited items
            txtCourseCode.Text = course.courseCode.ToString();
            txtCourseName.Text = course.name.ToString();
            txtLocation.Text = course.location.ToString();
            dtpTime.Value = DateTime.Parse(course.time.ToString());
            nudCapacity.Value = course.capacity;
            nudCredits.Value = course.credits;
        }

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
            coursesForm.coursesTableAdapter.Fill(coursesForm.studentManagerDBDataSet.Courses);
            coursesForm.dgvCourses.Refresh();
            coursesForm.dgvCourses.Parent.Refresh();

            // Close the form
            Close();
        }
    }
}
