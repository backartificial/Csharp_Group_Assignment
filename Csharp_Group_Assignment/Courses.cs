/**
 * 
 * File: Courses.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 11, 2018
 * 
 * 
 **/

// Include needed packages
using System;
using System.Data;
using System.Windows.Forms;

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for this form
    public partial class frmCourses : Form {
        /**
         * 
         * This function is used to initialize the component
         * 
         **/
        public frmCourses() {
            // Initialize the component
            InitializeComponent();
        }

        /**
         * 
         * This method is used to initialize the form, set the datagid view and then set the focus to the search input field
         * 
         **/
        private void Courses_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'studentManagerDBDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManagerDBDataSet.Courses);

            // Set focus to the txtbox on load
            txtSearchCourse.Focus();
        }

        /**
         * 
         * This function is used to show the other linking options
         * 
         **/
        private void btnLinkCourse_MouseEnter(object sender, EventArgs e) {
            // Make the options button visible to true
            pnlBtnLinkOption.Visible = true;
        }

        /**
         * 
         * This function is used to hide the other linking options
         * 
         **/
        private void frmCourses_MouseEnter(object sender, EventArgs e) {
            // Make the options button visible to false
            pnlBtnLinkOption.Visible = false;
        }

        /**
         * 
         * This function is used to hide the other linking options
         * 
         **/
        private void dgvCourses_MouseEnter(object sender, EventArgs e) {
            // Make the options button visible to false
            pnlBtnLinkOption.Visible = false;
        }

        /**
         * 
         * This function is used edit a selected
         * 
         **/
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

        /**
         * 
         * This function is used to remove a selected course
         * 
         **/
        private void btnRemoveCourse_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the table
            if (dgvCourses.SelectedCells.Count == 0) {
                // Dispaly an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have not selected a Course to remove.  Please select a Course to remove and try again.", "Course Selection Not Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (dgvCourses.SelectedCells.Count == 1) {
                // Select the curret row and store it into a variable
                DataGridViewRow selectedCourse = dgvCourses.CurrentRow;

                // Create a Course object to remove
                Course removeCourse = new Course(int.Parse(selectedCourse.Cells[0].Value.ToString()), selectedCourse.Cells[1].Value.ToString(), selectedCourse.Cells[2].Value.ToString(), selectedCourse.Cells[3].Value.ToString(), TimeSpan.Parse(selectedCourse.Cells[4].Value.ToString()), int.Parse(selectedCourse.Cells[5].Value.ToString()), int.Parse(selectedCourse.Cells[6].Value.ToString()));

                // Remove the course
                new frmRemoveCoruse(removeCourse, this).Show();
            } else {
                // Dispaly an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have made a selction of more than one Course.  Please select a single Course to remove and try again.", "Course Selection Made But More Than One", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /**
         * 
         * This function is used to dispaly the add course form
         * 
         **/
        private void btnAddCourse_Click(object sender, EventArgs e) {
            // Display the Add course Form
            new frmAddCourse(this).Show();
        }

        /**
         * 
         * This function is used to call the search function
         * 
         **/
        private void txtSearchCourse_TextChanged(object sender, EventArgs e) {
            // Perform the Course Search
            courseSearch();
        }

        /**
         * 
         * This function is used to call the search function
         *  
         **/
        private void btnSearchCourse_Click(object sender, EventArgs e) {
            // Perform the Course Search
            courseSearch();
        }

        /**
         * 
         * This function is used to search for a course, name or location based on the current text in the search input field
         *  
         **/
        private void courseSearch() {
            // Look in the DataGridView based on the passed value
            dgvCourses.DataSource = studentManagerDBDataSet.Courses.Where(x => x.courseCode.Contains(txtSearchCourse.Text) || x.name.Contains(txtSearchCourse.Text) || x.location.Contains(txtSearchCourse.Text)).CopyToDataTable();
        }
    }
}
