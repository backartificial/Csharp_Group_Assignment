using System;
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
            // Remove From ProgramCoruse

            // Remove from ProfessorCourse

            // Remove from StudentCourse

            // Remove the Course Parent

            // Refresh the DataGrid on the Courses form
            coursesForm.coursesTableAdapter.Fill(coursesForm.studentManagerDBDataSet.Courses);
            coursesForm.dgvCourses.Refresh();
            coursesForm.dgvCourses.Parent.Refresh();

            // Close the form
            Close();
        }
    }
}
