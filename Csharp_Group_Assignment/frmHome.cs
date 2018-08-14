/**
 * 
 * File: frmHome.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 14, 2018
 * 
 **/

using System;
using System.Windows.Forms;

// Namespace in which this class resides
namespace Csharp_Group_Assignment {
    // This is the class that handles the home page form
    public partial class frmHome : Form {
        /**
         * 
         * This method is used to initialize the main form
         * 
         **/
        public frmHome() {
            // Initializes the component
            InitializeComponent();
        }

        /**
         * 
         * This function is used to show the students page
         * 
         **/
        private void btnNavStudents_Click(object sender, EventArgs e) {
            // Set the section type to students
            FormsGlobal.frmStudentsAndProfessors.Current = info.LinkType.Students;

            // Show the students form
            FormsGlobal.frmStudentsAndProfessors.Show();

            // Hide the current form
            FormsGlobal.frmHome.Hide();
        }

        /**
         * 
         * This function is used to show the programs page
         * 
         **/
        private void btnNavPrograms_Click(object sender, EventArgs e) {
            // Show the programs form
            FormsGlobal.frmPrograms.Show();

            // Hide the current form
            FormsGlobal.frmHome.Hide();
        }

        /**
         * 
         * This function is used to show the courses page
         * 
         **/
        private void btnCourses_Click(object sender, EventArgs e) {
            // Show the courses form
            FormsGlobal.frmCourses.Show();

            // Hide the current form
            FormsGlobal.frmHome.Hide();
        }

        /**
         * 
         * This function is used to show the professors page
         * 
         **/
        private void btnNavProfessors_Click(object sender, EventArgs e) {
            // Set the section type to professors
            FormsGlobal.frmStudentsAndProfessors.Current = info.LinkType.Professors;

            // Show the professors form
            FormsGlobal.frmStudentsAndProfessors.Show();

            // Hide the current form
            FormsGlobal.frmHome.Hide();
        }
    }
}
