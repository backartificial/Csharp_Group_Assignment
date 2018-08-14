/**
 * 
 * File: frmLinkPrograms.cs
 * Developer: Emily Ramanna
 * Student Number: 991430310
 * Date: August 11, 2018
 * Description: Form to aid the user in linking a program to
 *              a course or student.
 * 
 **/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmLinkPrograms : Form {

        // Define needed class variables
        string linkSection; // is either "Course" or "Student"
        frmPrograms progFrm; // the form that was used to open this form

        /**
         * 
         * This function is used to initialize the form
         * 
         * @param linkSection: is the element to link a course to
         * @param progForm: is the form that is used to manipulate
         * 
         **/
        public frmLinkPrograms(string linkSection, frmPrograms progForm) {
            // Initialize component
            InitializeComponent();

            // Set Class variables
            this.linkSection = linkSection;
            this.progFrm = progForm;
        }

        /**
         * 
         * This function is used to run when the form is loading
         * 
         **/
        private void frmLink_Load(object sender, EventArgs e) {
            // Set the Form Titles and link button text
            Text = linkSection + " Link | Student Content Management System";
            lblTitle.Text = linkSection + " Link";
            btnLink.Text = "Link Program with " + linkSection;

            // Reposition the title label
            lblTitle.Location = new Point(((Size.Width / 2) - (lblTitle.Size.Width / 2)), lblTitle.Location.Y);

            // Set the Link Title
            lblLinkTitle.Text = linkSection;

            // Loop throug each course and assign it to the combobox
            foreach(DataRow row in progFrm.dtsAllData.Program) {
                // Add the program to the combobox
                cmbPrograms.Items.Add(new Programs(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["duration"].ToString()), char.Parse(row["coop"].ToString()), row["outcome"].ToString()));
            }

            // Prepare table columns
            tlpLinks.ColumnCount = 3;
            tlpLinks.RowCount = 1;
            tlpLinks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpLinks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpLinks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpLinks.Controls.Add(new Label() { Text = "Program", Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) }, 0, 0);
            tlpLinks.Controls.Add(new Label() { Text = "  " }, 1, 0);
            tlpLinks.Controls.Add(new Label() { Text = linkSection, Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) }, 2, 0);

            // Switch and perform different operations based on the desired linking
            switch (linkSection) {
                // Link operation for a Course
                case "Course":
                    // Fill the table adapter for Courses
                    coursesTableAdapter1.Fill(progFrm.dtsAllData.Courses);
                    courseProgramTableAdapter.Fill(progFrm.dtsAllData.CourseProgram);

                    // Loop through each course and assign it to the combobox
                    foreach (DataRow row in progFrm.dtsAllData.Courses) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Course(int.Parse(row["id"].ToString()), row["courseCode"].ToString(), row["name"].ToString(), row["location"].ToString(), TimeSpan.Parse(row["time"].ToString()), int.Parse(row["capacity"].ToString()), int.Parse(row["credits"].ToString())));
                    }

                    // Loop through each course and assign it to the combobox
                    foreach (DataRow row in progFrm.dtsAllData.CourseProgram) {
                        // Add the course to the table
                        tlpLinks.RowCount++;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["cname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["pname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                break;

                // Link operation for a Student
                case "Student":
                    // Fill the table adapter for Students
                    studentTableAdapter.Fill(progFrm.dtsAllData.Student);
                    studentProgramTableAdapter1.Fill(progFrm.dtsAllData.StudentProgram);

                    // Loop throug each Student and assign it to the combobox
                    foreach (DataRow row in progFrm.dtsAllData.Student) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Student(int.Parse(row["id"].ToString()), int.Parse(row["studentNumber"].ToString()), row["firstName"].ToString(), row["lastName"].ToString(), DateTime.Parse(row["birthday"].ToString()), char.Parse(row["gender"].ToString()), DateTime.Parse(row["startDate"].ToString())));
                    }

                    // Loop through each program and assign it to the combobox
                    foreach (DataRow row in progFrm.dtsAllData.StudentProgram) {
                        // Add the course to the table
                        tlpLinks.RowCount++;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["name"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["firstName"].ToString() + " " + row["lastName"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                break;
            }

            // Set the scrolling of the table
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tlpLinks.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        /**
         * 
         * This function is used to perform the actual linking in the database and then refresh the table layout
         * 
         **/
        private void btnLink_Click(object sender, EventArgs e) {
            // Check if the dropdows were selected
            if(cmbPrograms.SelectedIndex < 0 || cmbLink.SelectedIndex < 0) {
                // Display error message
                MessageBox.Show("Oops...  Looks like a Program or " + linkSection + " selection has not been made.  Please make a selection and try linking again.", "Selection not Made", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                // Store the program into a variable
                Programs program = (Programs)cmbPrograms.SelectedItem;

                // Switch based on the linkSection
                switch (linkSection) {
                    // Perform action when case is Course
                    case "Course":
                        // Create a variable to hold the Course
                        Course course = (Course)cmbLink.SelectedItem;

                        // Add the link into the database
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                            // Open the DB connection
                            connection.Open();

                            // Set the SqlCommand
                            SqlCommand command;

                            // Check if the link exists
                            using (command = new SqlCommand("SELECT COUNT(*) FROM CourseProgram WHERE courseId = @courseId AND programId = @programId", connection)) {
                                command.Parameters.AddWithValue("@courseId", course.id);
                                command.Parameters.AddWithValue("@programId", program.id);
                                Int32 count = (Int32)command.ExecuteScalar();

                                // Check if the link exists
                                if (count > 0) {
                                    // Display Error Message
                                    MessageBox.Show("Oops... Look like that Program to " + linkSection + " link already exists.  Please create a new link and try again!", "Link Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Close the DB connection
                                    connection.Close();
                                } else {
                                    // Add the Link
                                    using (command = new SqlCommand("INSERT INTO CourseProgram (courseId, programId) VALUES (@courseId, @programId)", connection)) {
                                        command.Parameters.AddWithValue("@courseId", course.id);
                                        command.Parameters.AddWithValue("@programId", program.id);
                                        command.ExecuteNonQuery();

                                        // Add the data to the table
                                        tlpLinks.RowCount++;
                                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                        tlpLinks.Controls.Add(new TextBox() { Text = course.name, ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new TextBox() { Text = program.name, ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                                        
                                        // Display Success Message
                                        MessageBox.Show("Success!  Link successfully made!", "Link Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmbPrograms.SelectedIndex = -1;
                                        cmbLink.SelectedIndex = -1;

                                        // Close the DB connection
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    break;

                   

                    // Perform action when case is Student
                    case "Student":
                        // Create a variable to hold the Student
                        Student student = (Student)cmbLink.SelectedItem;

                        // Add the link into the database
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                            // Open the DB connection
                            connection.Open();

                            // Set the SqlCommand
                            SqlCommand command;

                            // Check if the link exists
                            using (command = new SqlCommand("SELECT COUNT(*) FROM StudentProgram WHERE programid = @progId AND studentId = @studentId", connection)) {
                                command.Parameters.AddWithValue("@progId", program.id);
                                command.Parameters.AddWithValue("@studentId", student.id);
                                Int32 count = (Int32)command.ExecuteScalar();

                                // Check if the link exists
                                if (count > 0) {
                                    // Display Error Message
                                    MessageBox.Show("Oops... Look like that Course to " + linkSection + " link already exists.  Please create a new link and try again!", "Link Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Close the DB connection
                                    connection.Close();
                                } else {
                                    // Add the Link
                                    using (command = new SqlCommand("INSERT INTO StudentProgram (programId, studentId) VALUES (@progId, @studentId)", connection)) {
                                        command.Parameters.AddWithValue("@progId", program.id);
                                        command.Parameters.AddWithValue("@studentId", student.id);
                                        command.ExecuteNonQuery();

                                        // Add the data to the table
                                        tlpLinks.RowCount++;
                                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                        tlpLinks.Controls.Add(new TextBox() { Text = program.name, ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new TextBox() { Text = student.name, ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));

                                        // Display Success Message
                                        MessageBox.Show("Success!  Link successfully made!", "Link Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmbPrograms.SelectedIndex = -1;
                                        cmbLink.SelectedIndex = -1;
                                        // Close the DB connection
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    break;
                }
            }
        }

        /**
         * 
         * This function is used to close the form
         * 
         **/
        private void btnClose_Click(object sender, EventArgs e) {
            // Check if the user wants to actually exit
            if(cmbPrograms.SelectedIndex > -1 || cmbLink.SelectedIndex > -1) {
                // Display Confirmation message
                DialogResult closeOption = MessageBox.Show("Oops...  Loooks like you have attempted to make a link.  Are you sure you want to cancel making the link?", "Form Closure Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Check if the user wants to exit
                if(closeOption == DialogResult.Yes) {
                    // Close the form
                    Close();
                }
            }else{
                // Close the form
                Close();
            }
        }
    }
}
