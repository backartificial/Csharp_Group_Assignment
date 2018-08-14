/**
 * 
 * File: frmPrograms.cs
 * Developer: Emily Ramanna
 * Student Number: 991430310
 * Date: August 11, 2018
 * Description: Main page for Program functionality
 * 
 **/

// Include needed packages
using System;
using System.Data;
using System.Windows.Forms;


// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for this form
    public partial class frmPrograms : Form {
        /**
         * 
         * This function is used to initialize the component
         * 
         **/
        public frmPrograms() {
            // Initialize the component
            InitializeComponent();
        }

        /**
         * 
         * This method is used to initialize the form, set the datagid view and then set the focus to the search input field
         * 
         **/
        private void Programs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsAllData.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.dtsAllData.Program);
            // TODO: This line of code loads data into the 'dtsAllData.Program' table. You can move, or remove it, as needed.
            programTableAdapter.Fill(dtsAllData.Program);


            // Set focus to the txtbox on load
            txtSearchProgram.Focus();
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

        private void btnLinkProgram_MouseEnter(object sender, EventArgs e)
        {
            // Make the options button visible to true
            pnlBtnLinkOption.Visible = true;
        }

        /**
         * 
         * This function is used to hide the other linking options
         * 
         **/
        private void frmPrograms_MouseEnter(object sender, EventArgs e)
        {
            // Make the options button visible to false
            pnlBtnLinkOption.Visible = false;
        }

        /**
         * 
         * This function is used to hide the other linking options
         * 
         **/
        private void dvgPrograms_MouseEnter(object sender, EventArgs e)
        {
            // Make the options button visible to false
            pnlBtnLinkOption.Visible = false;
        }

        /**
         * This function is used to start editing a selected program
         **/ 
        private void btnEditProgram_Click(object sender, EventArgs e)
        {
            // Check if a cell has been selected in the table
            if (dgvPrograms.SelectedCells.Count == 0)
            {
                // Dispaly an error message showing that there is no course selected to edit
                MessageBox.Show("Oops... You have not selected a Program to edit.  Please select a Program to edit and try again.", "Program Selection Not Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgvPrograms.SelectedCells.Count == 1)
            {
                // Select the curret row and store it into a variable
                DataGridViewRow selectedProgram = dgvPrograms.CurrentRow;

                // Create a Course object to edit
                Programs editProgram = new Programs(int.Parse(selectedProgram.Cells[0].Value.ToString()), selectedProgram.Cells[1].Value.ToString(), int.Parse(selectedProgram.Cells[2].Value.ToString()), char.Parse(selectedProgram.Cells[3].Value.ToString()), selectedProgram.Cells[4].Value.ToString());

                // Edit the Course the course
                new frmEditPrograms(editProgram, this).Show();
            }
            else
            {
                // Dispaly an error message showing that there is no course selected to edit
                MessageBox.Show("Oops... You have made a selction of more than one Program.  Please select a single Program to edit and try again.", "Program Selection Made But More Than One", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /**
         * 
         * This function is used to remove a selected program
         * 
         **/
        private void btnRemoveProgram_Click(object sender, EventArgs e)
        {
            // Check if a cell has been selected in the table
            if (dgvPrograms.SelectedCells.Count == 0)
            {
                // Display an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have not selected a Program to remove.  Please select a Program to remove and try again.", "Program Selection Not Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgvPrograms.SelectedCells.Count == 1)
            {
                // Select the curret row and store it into a variable
                DataGridViewRow selectedProgram = dgvPrograms.CurrentRow;

                // Create a Course object to remove
                Programs removeProgram = new Programs(int.Parse(selectedProgram.Cells[0].Value.ToString()), selectedProgram.Cells[1].Value.ToString(), int.Parse(selectedProgram.Cells[2].Value.ToString()), char.Parse(selectedProgram.Cells[3].Value.ToString()), selectedProgram.Cells[4].Value.ToString());

                // Remove the course
                new frmRemovePrograms(removeProgram, this).Show();
            }
            else
            {
                // Display an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have made a selction of more than one Program.  Please select a single Program to remove and try again.", "Program Selection Made But More Than One", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        /**
         * 
         * This function is used to dispaly the add course form
         * 
         **/
        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            // Display the Add course Form
            new frmAddPrograms(this).Show();
        }

        /**
         * 
         * This function is used to call the search function as the user types
         * 
         **/
        private void txtSearchProgram_TextChanged(object sender, EventArgs e)
        {
            // Perform the Program Search
            programSearch();
        }

        /**
         * 
         * This function is used to call the search function
         *  
         **/
        private void btnSearchProgram_Click(object sender, EventArgs e)
        {
            // Perform the Program Search
            programSearch();
        }

        /**
         * 
         * This function is used to search for a program, name or outcome based on the current text in the search input field
         *  
         **/
        private void programSearch() {
            // Try and filter the table
            try {
                //  Look in the DataGridView based on the passed value
                dgvPrograms.DataSource = dtsAllData.Program.Where(x => x.name.Contains(txtSearchProgram.Text) || x.outcome.Contains(txtSearchProgram.Text)).CopyToDataTable();
            }catch(InvalidOperationException) {
                // Do nothing
            }
        }

        /**
         * 
         * Ths function is used to open the link form and pass in that the user would like to link a course to a program
         * 
         **/
        private void btnLinkProgram_Click(object sender, EventArgs e) {
            // Open the link form
            new frmLinkPrograms("Course", this).Show();
        }

        /**
         * 
         * Ths function is used to open the link form and pass in that the user would like to link a course to a professor
         * 
         **/
        private void btnLinkProfessor_Click(object sender, EventArgs e) {
            // Open the link form
            new frmLinkPrograms("Professor", this).Show();
        }
        
        /**
         * 
         * Ths function is used to open the link form and pass in that the user would like to link a course to a student
         * 
         **/
        private void btnLinkStudent_Click(object sender, EventArgs e) {
            // Open the link form
            new frmLinkPrograms("Student", this).Show();
        }

        /**
         * 
         * This function is used when the report button is clicked to create the report
         * 
         **/
        private void btnPrintProgramReport_Click(object sender, EventArgs e)
        {
            new frmProgramsReport(this).Show();
        }

        /** Generated method whilst debugging. Need to specify that nothing is done
         *  when the bindingSource changes.
         **/ 
        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        /** Generated method whilst debugging. ToolStripButton action.
         **/ 
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                programTableAdapter.Fill(dtsAllData.Program);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /**
         * 
         * This function is used to rename the coop value to True/False
         * 
         **/ 
        private void dgvPrograms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // Check if the column is the coop column
            if (e.ColumnIndex == 3) {
                // Check if the value is 0 - NO/False
                e.Value = (e.Value.Equals("0")) ? "No" :  "Yes";
            }
        }

        /** action to open course form */
        private void btnCourses_Click(object sender, EventArgs e) {
            // Shor course form
            FormsGlobal.frmCourses.Show();

            // close my programs form
            FormsGlobal.frmPrograms.Close();
        }

        /**
         * 
         * This function is used when a used desires to view the students/professors section
         * 
         **/
        private void btnNavStudents_Click(object sender, EventArgs e) {
            // Set the view state to Students
            FormsGlobal.frmStudentsAndProfessors.Current = info.LinkType.Students;

            // Show the Programs Form
            FormsGlobal.frmStudentsAndProfessors.Show();

            // Close this form
            FormsGlobal.frmPrograms.Close();
        }

        /**
         * 
         * This function is used when a used desires to view the students/professors section
         * 
         **/
        private void btnNavProfessors_Click(object sender, EventArgs e) {
            // Set the view state to Students
            FormsGlobal.frmStudentsAndProfessors.Current = info.LinkType.Professors;

            // Show the Programs Form
            FormsGlobal.frmStudentsAndProfessors.Show();

            // Close this form
            FormsGlobal.frmPrograms.Close();
        }

        /**
         * 
         * This function is used when a used desires to view the home form
         * 
         **/
        private void btnNavHome_Click(object sender, EventArgs e) {
            // Show the Home Form
            FormsGlobal.frmHome.Show();

            // Close this form
            FormsGlobal.frmPrograms.Close();
        }
    }
}