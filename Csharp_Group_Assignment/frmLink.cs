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
            // Fill the course table adapter with data
            programTableAdapter.Fill(coursesForm.dtsAllData.Program);

            // Set the Form Titles
            Text = linkSection + " Link | Student Content Management System";
            lblTitle.Text = linkSection + " Link";

            // Reposition the title label
            lblTitle.Location = new Point(((Size.Width / 2) - (lblTitle.Size.Width / 2)), lblTitle.Location.Y);

            // Set the Link Title
            lblLinkTitle.Text = linkSection;

            // Loop throug each course and assign it to the combobox
            foreach(DataRow row in coursesForm.dtsAllData.Courses) {
                // Add the course to the combobox
                cmbCourses.Items.Add(new Course(int.Parse(row["id"].ToString()), row["courseCode"].ToString(), row["name"].ToString(), row["location"].ToString(), TimeSpan.Parse(row["time"].ToString()), int.Parse(row["capacity"].ToString()), int.Parse(row["credits"].ToString())).name);
            }

            tlpLinks.ColumnCount = 3;
            tlpLinks.RowCount = 1;
            tlpLinks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpLinks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpLinks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpLinks.Controls.Add(new Label() { Text = "Course", Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) }, 0, 0);
            tlpLinks.Controls.Add(new Label() { Text = "  " }, 1, 0);
            tlpLinks.Controls.Add(new Label() { Text = linkSection, Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) }, 2, 0);

            // Switch and perform different operations based on the desired linking
            switch (linkSection) {
                // Link operation for a Program
                case "Program":
                    // Fill the table adapter for Programs
                    courseProgramTableAdapter.Fill(coursesForm.dtsAllData.CourseProgram);

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.Program) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Programs(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["duration"].ToString()), char.Parse(row["coop"].ToString()), row["outcome"].ToString()).name);
                    }

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.CourseProgram) {
                        // Add the course to the table
                        tlpLinks.RowCount = tlpLinks.RowCount + 1;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["cname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["pname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                break;

                // Link operation for a Program
                case "Professor":
                    // Fill the table adapter for Programs
                    courseProgramTableAdapter.Fill(coursesForm.dtsAllData.CourseProgram);

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.Program) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Programs(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["duration"].ToString()), char.Parse(row["coop"].ToString()), row["outcome"].ToString()).name);
                    }

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.CourseProgram) {
                        // Add the course to the table
                        tlpLinks.RowCount = tlpLinks.RowCount + 1;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["cname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["pname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                    break;
            }
        }
    }
}
