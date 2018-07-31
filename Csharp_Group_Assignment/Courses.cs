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
            }else if(dgvCourses.SelectedCells.Count == 1) {
                // Select the curret row and store it into a variable
                DataGridViewRow selectedCourse = dgvCourses.CurrentRow;

                // Create a Course object to edit
                Course editCourse = new Course(int.Parse(selectedCourse.Cells[0].Value.ToString()), selectedCourse.Cells[1].Value.ToString(), selectedCourse.Cells[2].Value.ToString(), selectedCourse.Cells[3].Value.ToString(), TimeSpan.Parse(selectedCourse.Cells[4].Value.ToString()), int.Parse(selectedCourse.Cells[5].Value.ToString()), int.Parse(selectedCourse.Cells[6].Value.ToString()));

                // Edit the Course the course
                new frmEditCourse(editCourse, this).Show();
            } else{
                // Dispaly an error message showing that there is no course selected to edit
                MessageBox.Show("Oops... You have made a selction of more than one Course.  Please select a single Course to edit and try again.", "Course Selection Made But More Than One", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }else if(dgvCourses.SelectedCells.Count == 1){
                // Select the curret row and store it into a variable
                DataGridViewRow selectedCourse = dgvCourses.CurrentRow;

                // Create a Course object to remove
                Course removeCourse = new Course(int.Parse(selectedCourse.Cells[0].Value.ToString()), selectedCourse.Cells[1].Value.ToString(), selectedCourse.Cells[2].Value.ToString(), selectedCourse.Cells[3].Value.ToString(), TimeSpan.Parse(selectedCourse.Cells[4].Value.ToString()), int.Parse(selectedCourse.Cells[5].Value.ToString()), int.Parse(selectedCourse.Cells[6].Value.ToString()));

                // Remove the course
                new frmRemoveCoruse(removeCourse, this).Show();
            }else{
                // Dispaly an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have made a selction of more than one Course.  Please select a single Course to remove and try again.", "Course Selection Made But More Than One", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e) {
            // Display the Add course Form
            new frmAddCourse(this).Show();
        }
    }
}
