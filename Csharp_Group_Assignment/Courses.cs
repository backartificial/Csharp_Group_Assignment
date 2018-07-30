using System;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmCourses : Form {
        public frmCourses() {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'studentManagerDBDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManagerDBDataSet.Courses);

        }

        private void btnLinkCourse_MouseEnter(object sender, EventArgs e) {
            pnlBtnLinkOption.Visible = true;
        }

        private void frmCourses_MouseEnter(object sender, EventArgs e) {
            pnlBtnLinkOption.Visible = false;
        }

        private void dgvCourses_MouseEnter(object sender, EventArgs e) {
            pnlBtnLinkOption.Visible = false;
        }

        private void btnEditCourse_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the table
            if(dgvCourses.SelectedCells.Count == 0) {
                // Dispaly an error message showing that there is no course selected to edit
                MessageBox.Show("Oops... You have not selected a Course to edit.  Please select a Course to edit and try again.", "Course Selection Not Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchCourse_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == Convert.ToChar(Keys.Return)) {
                // Perform the course search

            }
        }

        private void btnSearchCourse_Click(object sender, EventArgs e) {
            // Perform the Course Search
        }

        private void courseSearch(string value) {
            // Look in the DataGridView based on the passed value
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the table
            if (dgvCourses.SelectedCells.Count == 0) {
                // Dispaly an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have not selected a Course to remove.  Please select a Course to remove and try again.", "Course Selection Not Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e) {
            // Display the Add course Form
            new frmAddCourse().Show();
        }
    }
}
