using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmLink : Form {
        // Define needed class variables
        string linkSection;
        frmCourses coursesForm;

        /**
         * 
         * This function is used to initialize the form
         * 
         * @param linkSection: is the section to link a course to
         * @param courseForm: is the form that is used to manipulate
         * 
         **/
        public frmLink(string linkSection, frmCourses coursesForm) {
            // Initialize component
            InitializeComponent();

            // Set Class variables
            this.linkSection = linkSection;
            this.coursesForm = coursesForm;
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
            btnLink.Text = "Link Course with " + linkSection;

            // Reposition the title label
            lblTitle.Location = new Point(((Size.Width / 2) - (lblTitle.Size.Width / 2)), lblTitle.Location.Y);

            // Set the Link Title
            lblLinkTitle.Text = linkSection;

            // Loop throug each course and assign it to the combobox
            foreach(DataRow row in coursesForm.dtsAllData.Courses) {
                // Add the course to the combobox
                cmbCourses.Items.Add(new Course(int.Parse(row["id"].ToString()), row["courseCode"].ToString(), row["name"].ToString(), row["location"].ToString(), TimeSpan.Parse(row["time"].ToString()), int.Parse(row["capacity"].ToString()), int.Parse(row["credits"].ToString())).name);
            }

            // Prepare table columns
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
                    programTableAdapter.Fill(coursesForm.dtsAllData.Program);
                    courseProgramTableAdapter.Fill(coursesForm.dtsAllData.CourseProgram);

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.Program) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Programs(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["duration"].ToString()), char.Parse(row["coop"].ToString()), row["outcome"].ToString()).name);
                    }

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.CourseProgram) {
                        // Add the course to the table
                        tlpLinks.RowCount++;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["cname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["pname"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                break;

                // Link operation for a Professor
                case "Professor":
                    // Fill the table adapter for Professors
                    professorTableAdapter.Fill(coursesForm.dtsAllData.Professor);
                    professorCourseTableAdapter.Fill(coursesForm.dtsAllData.ProfessorCourse);

                    // Loop throug each professor and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.Professor) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Professor(int.Parse(row["id"].ToString()), int.Parse(row["employeeNumber"].ToString()), row["firstName"].ToString(), row["lastName"].ToString(), DateTime.Parse(row["birthday"].ToString()), char.Parse(row["gender"].ToString()), DateTime.Parse(row["startDate"].ToString())).name);
                    }

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.ProfessorCourse) {
                        // Add the course to the table
                        tlpLinks.RowCount++;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["name"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["firstName"].ToString() + " " + row["lastName"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                break;

                // Link operation for a Student
                case "Student":
                    // Fill the table adapter for Students
                    studentTableAdapter.Fill(coursesForm.dtsAllData.Student);
                    studentCourseTableAdapter.Fill(coursesForm.dtsAllData.StudentCourse);

                    // Loop throug each Student and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.Student) {
                        // Add the course to the combobox
                        cmbLink.Items.Add(new Student(int.Parse(row["id"].ToString()), int.Parse(row["studentNumber"].ToString()), row["firstName"].ToString(), row["lastName"].ToString(), DateTime.Parse(row["birthday"].ToString()), char.Parse(row["gender"].ToString()), DateTime.Parse(row["startDate"].ToString())).name);
                    }

                    // Loop throug each program and assign it to the combobox
                    foreach (DataRow row in coursesForm.dtsAllData.StudentCourse) {
                        // Add the course to the table
                        tlpLinks.RowCount++;
                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["name"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                        tlpLinks.Controls.Add(new TextBox() { Text = row["firstName"].ToString() + " " + row["lastName"].ToString(), ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));
                    }
                break;
            }
        }

        /**
         * 
         * This function is used to perform the actual linking in the database and then refresh the table layout
         * 
         **/
        private void btnLink_Click(object sender, EventArgs e) {
            // Check if the dropdows were selected
            if(cmbCourses.SelectedIndex < 0 || cmbLink.SelectedIndex < 0) {
                // Display error message
                MessageBox.Show("Oops...  Looks like a Course or " + linkSection + " selection has not been made.  Please make a selection and try linking again.", "Selection not Made", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                // Store the course into a variable
                Course course = (Course)cmbCourses.SelectedItem;

                // Switch based on the linkSection
                switch (linkSection) {
                    // Perform action when case is Program
                    case "Program":
                        // Create a variable to hold the Program
                        Programs program = (Programs)cmbLink.SelectedItem;

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
                                    MessageBox.Show("Oops... Look like that Course to " + linkSection + " link already exists.  Please create a new link and try again!", "Link Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                                        // Close the DB connection
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    break;

                    // Perform action when case is Professor
                    case "Professor":
                        // Create a variable to hold the Program
                        Professor professor = (Professor)cmbLink.SelectedItem;

                        // Add the link into the database
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                            // Open the DB connection
                            connection.Open();

                            // Set the SqlCommand
                            SqlCommand command;

                            // Check if the link exists
                            using (command = new SqlCommand("SELECT COUNT(*) FROM ProfessorCourse WHERE courseId = @courseId AND professorId = @professorId", connection)) {
                                command.Parameters.AddWithValue("@courseId", course.id);
                                command.Parameters.AddWithValue("@professorId", professor.id);
                                Int32 count = (Int32)command.ExecuteScalar();

                                // Check if the link exists
                                if (count > 0) {
                                    // Display Error Message
                                    MessageBox.Show("Oops... Look like that Course to " + linkSection + " link already exists.  Please create a new link and try again!", "Link Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Close the DB connection
                                    connection.Close();
                                } else {
                                    // Add the Link
                                    using (command = new SqlCommand("INSERT INTO ProfessorCourse (courseId, professorId) VALUES (@courseId, @professorId)", connection)) {
                                        command.Parameters.AddWithValue("@courseId", course.id);
                                        command.Parameters.AddWithValue("@professorId", professor.id);
                                        command.ExecuteNonQuery();

                                        // Add the data to the table
                                        tlpLinks.RowCount++;
                                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                        tlpLinks.Controls.Add(new TextBox() { Text = course.name, ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new TextBox() { Text = professor.name, ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));

                                        // Close the DB connection
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    break;

                    // Perform action when case is Professor
                    case "Student":
                        // Create a variable to hold the Program
                        Student student = (Student)cmbLink.SelectedItem;

                        // Add the link into the database
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString)) {
                            // Open the DB connection
                            connection.Open();

                            // Set the SqlCommand
                            SqlCommand command;

                            // Check if the link exists
                            using (command = new SqlCommand("SELECT COUNT(*) FROM StudentCourse WHERE courseId = @courseId AND studentId = @studentId", connection)) {
                                command.Parameters.AddWithValue("@courseId", course.id);
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
                                    using (command = new SqlCommand("INSERT INTO StudentCourse (courseId, studentId) VALUES (@courseId, @studentId)", connection)) {
                                        command.Parameters.AddWithValue("@courseId", course.id);
                                        command.Parameters.AddWithValue("@studentId", student.id);
                                        command.ExecuteNonQuery();

                                        // Add the data to the table
                                        tlpLinks.RowCount++;
                                        tlpLinks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                        tlpLinks.Controls.Add(new TextBox() { Text = course.name, ReadOnly = true, Dock = DockStyle.Fill }, 0, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new Label() { Text = "=>", TextAlign = ContentAlignment.MiddleCenter }, 1, (tlpLinks.RowCount - 1));
                                        tlpLinks.Controls.Add(new TextBox() { Text = student.name, ReadOnly = true, Dock = DockStyle.Fill }, 2, (tlpLinks.RowCount - 1));

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
            // Close the form
            Close();
        }
    }
}
