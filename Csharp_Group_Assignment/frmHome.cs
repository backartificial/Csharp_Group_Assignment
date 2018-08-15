/**
 * 
 * File: frmHome.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 14, 2018
 * 
 **/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        /**
         * 
         * This funcion is used to display the chart on the main page
         * 
         **/
        private void frmHome_Load(object sender, EventArgs e) {
            // Reset default chart options
            chtMain.Series.Clear();
            chtMain.Legends.Clear();

            // Add Legend
            chtMain.Legends.Add("Tables");
            chtMain.Legends[0].LegendStyle = LegendStyle.Table;
            chtMain.Legends[0].Docking = Docking.Bottom;
            chtMain.Legends[0].Alignment = StringAlignment.Center;
            chtMain.Legends[0].Title = "Database Distribution";
            chtMain.Legends[0].BorderColor = Color.Black;

            // Add Chart Series
            string seriesName = "Database Distribution";
            chtMain.Series.Add(seriesName);
            chtMain.Series[seriesName].ChartType = SeriesChartType.Pie;
            chtMain.Series[seriesName].Points.AddXY("Programs", FormsGlobal.frmCourses.dtsAllData.Program.Count);
            chtMain.Series[seriesName].Points.AddXY("Courses", FormsGlobal.frmCourses.dtsAllData.Courses.Count);
            chtMain.Series[seriesName].Points.AddXY("Students", FormsGlobal.frmCourses.dtsAllData.Student.Count);
            chtMain.Series[seriesName].Points.AddXY("Professors", FormsGlobal.frmCourses.dtsAllData.Professor.Count);

            // Loop though each data point and show the percentage and value
            foreach (DataPoint p in chtMain.Series[seriesName].Points) {
                // Set label to values and percentage
                p.Label = "#VALX\n#PERCENT";
            }
        }
    }
}
