using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmLink : Form {
        // Define needed class variables
        string linkSection;
        frmCourses coursesForm;

        public frmLink(string linkSection, frmCourses coursesForm) {
            // Initialize component
            InitializeComponent();

            // Set Class variables
            this.linkSection = linkSection;
            this.coursesForm = coursesForm;
        }

        private void frmLink_Load(object sender, EventArgs e) {
            // Set the Form Titles
            Text = linkSection + " Link | Student Content Management System";
            lblTitle.Text = linkSection + " Link";

            // Reposition the title label
            lblTitle.Location = new Point(((Size.Width / 2) - (lblTitle.Size.Width / 2)), lblTitle.Location.Y);

            // Set the Link Title
            lblLinkTitle.Text = linkSection;

            // Loop throug each course and assign it to the combobox
            foreach(DataRow row in coursesForm.studentManagerDBDataSet.Courses) {
                // Add the course to the combobox
                cmbCourses.Items.Add(new Course(int.Parse(row["id"].ToString()), row["courseCode"].ToString(), row["name"].ToString(), row["location"].ToString(), TimeSpan.Parse(row["time"].ToString()), int.Parse(row["capacity"].ToString()), int.Parse(row["credits"].ToString())).name);
            }

            MessageBox.Show(coursesForm.studentManagerDBDataSet.CourseProgram.Count.ToString());
        }
    }
}
