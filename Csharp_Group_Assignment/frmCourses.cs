/**
 * 
 * File: Courses.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 11, 2018
 * 
 **/

// Include needed packages
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using IronPdf;

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
            // TODO: This line of code loads data into the 'dtsAllData.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.dtsAllData.Program);
            // TODO: This line of code loads data into the 'dtsAllData.Courses' table. You can move, or remove it, as needed.
            coursesTableAdapter.Fill(dtsAllData.Courses);

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
            if(dgvCourses.SelectedCells.Count == 0) {
                // Dispaly an error message showing that there is no course selected to remove
                MessageBox.Show("Oops... You have not selected a Course to remove.  Please select a Course to remove and try again.", "Course Selection Not Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (dgvCourses.SelectedCells.Count == 1){
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
            // Try and filter the table
            try {
                //  Look in the DataGridView based on the passed value
                dgvCourses.DataSource = dtsAllData.Courses.Where(x => x.courseCode.Contains(txtSearchCourse.Text) || x.name.Contains(txtSearchCourse.Text) || x.location.Contains(txtSearchCourse.Text)).CopyToDataTable();
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
            new frmLinkCourse("Program", this).Show();
        }

        /**
         * 
         * Ths function is used to open the link form and pass in that the user would like to link a course to a professor
         * 
         **/
        private void btnLinkProfessor_Click(object sender, EventArgs e) {
            // Open the link form
            new frmLinkCourse("Professor", this).Show();
        }
        
        /**
         * 
         * Ths function is used to open the link form and pass in that the user would like to link a course to a student
         * 
         **/
        private void btnLinkStudent_Click(object sender, EventArgs e) {
            // Open the link form
            new frmLinkCourse("Student", this).Show();
        }

        /**
         * 
         * This function is used when the report button is clicked to create the report
         * 
         **/
        private void btnPrintCourseReport_Click(object sender, EventArgs e) {
            // Fill the Table Adapters
            programTableAdapter.Fill(dtsAllData.Program);
            courseProgramTableAdapter.Fill(dtsAllData.CourseProgram);
            professorCourseTableAdapter.Fill(dtsAllData.ProfessorCourse);
            studentCourseTableAdapter.Fill(dtsAllData.StudentCourse);

            // Sort the DataSetViews by course id
                // Course-Program Data View
                DataView courseProgramView = new DataView(dtsAllData.CourseProgram);
                courseProgramView.Sort = "courseId ASC";

                // Course-Professor Data View
                DataView courseProfessorView = new DataView(dtsAllData.ProfessorCourse);
                courseProfessorView.Sort = "courseId ASC";

                // Course-Student Data View
                DataView courseStudentView = new DataView(dtsAllData.StudentCourse);
                courseStudentView.Sort = "courseId ASC";

            // Create the needed rendering variable
            HtmlToPdf Renderer = new HtmlToPdf();

            // Set rendering options
            Renderer.PrintOptions.Title = "Courses Report - " + DateTime.Now.ToLongDateString();
            Renderer.PrintOptions.DPI = 600;
            
            // Header Options
            Renderer.PrintOptions.FirstPageNumber = 1;
            Renderer.PrintOptions.Header.DrawDividerLine = true;
            Renderer.PrintOptions.Header.LeftText = "Courses Report - " + DateTime.Now.ToLongDateString();
            Renderer.PrintOptions.Header.FontFamily = "Helvetica,Arial";
            Renderer.PrintOptions.Header.FontSize = 12;

            // Footer options
            Renderer.PrintOptions.Footer.DrawDividerLine = true;
            Renderer.PrintOptions.Footer.FontFamily = "Arial";
            Renderer.PrintOptions.Footer.FontSize = 10;
            Renderer.PrintOptions.Footer.LeftText = "{date} {time}";
            Renderer.PrintOptions.Footer.RightText = "{page} of {total-pages}";

            //  Create the needed HTML to create the PDF
            string htmlPDFFile = "";

            // Add file CSS Style
            htmlPDFFile += "<style>" +
                                "* {" +
                                    "font-family: Helvetica, Arial;" +
                                "}" +

                                "table, th, td {" +
                                    "border: 1px solid black;" +
                                    "border-collapse: collapse;" +
                                "}" +
                            "</style>";

            // Add Short Summary
            htmlPDFFile += "<h3>Summary Information<h3><table style='width:100%;'>" + 
                                "<thead>" +
                                    "<tr>" +
                                        "<th>Number of Courses</th>" +
                                        "<th>Linked Programs</th>" +
                                        "<th>Linked Professors</th>" +
                                        "<th>Linked Students</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>" +
                                    "<tr>" +
                                        "<td align='center'>" + dtsAllData.Courses.Count + "</td>" +
                                        "<td align='center'>" + dtsAllData.CourseProgram.Count + "</td>" +
                                        "<td align='center'>" + dtsAllData.ProfessorCourse.Count + "</td>" +
                                        "<td align='center'>" + dtsAllData.StudentCourse.Count + "</td>" +
                                    "</tr>" +
                                "</tbody>" +
                            "</table>";

            // Add Spacing before adding in the Courses Table info
            htmlPDFFile += "<br/><br/>";

            // Add in the Courses Table
            htmlPDFFile += "<h3>Courses Information<h3><table style='width:100%;'>" +
                                "<thead>" +
                                    "<tr>" +
                                        "<th>Course Id</th>" +
                                        "<th>Course Code</th>" +
                                        "<th>Course Name</th>" +
                                        "<th>Course Location</th>" +
                                        "<th>Course Time</th>" +
                                        "<th>Course Capacity</th>" +
                                        "<th>Course Credits</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>";

            // Loop throug each course
            foreach (DataRow row in dtsAllData.Courses) {
                // Create a new Course instance with the correct information
                Course rowCourse = new Course(int.Parse(row["id"].ToString()), row["courseCode"].ToString(), row["name"].ToString(), row["location"].ToString(), TimeSpan.Parse(row["time"].ToString()), int.Parse(row["capacity"].ToString()), int.Parse(row["credits"].ToString()));

                // Add the course to the table
                htmlPDFFile += "<tr>" +
                                    "<td>" + rowCourse.id + "</td>" +
                                    "<td>" + rowCourse.courseCode + "</td>" +
                                    "<td>" + rowCourse.name + "</td>" +
                                    "<td>" + rowCourse.location + "</td>" +
                                    "<td>" + rowCourse.time + "</td>" +
                                    "<td>" + rowCourse.capacity + "</td>" +
                                    "<td>" + float.Parse(rowCourse.credits.ToString()) + "</td>" +
                                "</tr>";
            }

            // Close Course Table
            htmlPDFFile += "</tbody></table>";

            // Add Spacing before adding in the Courses Table info
            htmlPDFFile += "<br/><br/>";

            // Add in the ProgramCourse Table
            htmlPDFFile += "<h3>Course-Program Link Information<h3><table style='width:100%;'>" +
                                "<thead>" +
                                    "<tr>" +
                                        "<th>Course Name</th>" +
                                        "<th></th>" +
                                        "<th>Program Name</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>";

            // Loop throug each Course-Program
            foreach (DataRowView row in courseProgramView) {
                // Add the Course-Program to the table
                htmlPDFFile += "<tr>" +
                                    "<td>" + row["cname"].ToString() + "</td>" +
                                    "<td align='center'> => </td>" +
                                    "<td>" + row["pname"].ToString() + "</td>" +
                                "</tr>";
            }

            // Close Course-Program Table
            htmlPDFFile += "</tbody></table>";

            // Add Spacing before adding in the Courses Table info
            htmlPDFFile += "<br/><br/>";

            // Add in the Course-Professor Table
            htmlPDFFile += "<h3>Course-Professor Link Information<h3><table style='width:100%;'>" +
                                "<thead>" +
                                    "<tr>" +
                                        "<th>Course Name</th>" +
                                        "<th></th>" +
                                        "<th>Professor Name</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>";

            // Loop throug each Course-Professor
            foreach (DataRowView row in courseProfessorView) {
                // Add the Course-Professor to the table
                htmlPDFFile += "<tr>" +
                                    "<td>" + row["name"].ToString() + "</td>" +
                                    "<td align='center'> => </td>" +
                                    "<td>" + row["firstName"].ToString() + " " + row["lastName"].ToString() + "</td>" +
                                "</tr>";
            }

            // Close Course-Professor Table
            htmlPDFFile += "</tbody></table>";

            // Add Spacing before adding in the Courses Table info
            htmlPDFFile += "<br/><br/>";

            // Add in the Course-Student Table
            htmlPDFFile += "<h3>Course-Student Link Information<h3><table style='width:100%;'>" +
                                "<thead>" +
                                    "<tr>" +
                                        "<th>Course Name</th>" +
                                        "<th></th>" +
                                        "<th>Student Name</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>";

            // Loop throug each Course-Student
            foreach (DataRowView row in courseStudentView) {
                // Add the Course-Student to the table
                htmlPDFFile += "<tr>" +
                                    "<td>" + row["name"].ToString() + "</td>" +
                                    "<td align='center'> => </td>" +
                                    "<td>" + row["firstName"].ToString() + " " + row["lastName"].ToString() + "</td>" +
                                "</tr>";
            }

            // Close Course-Student Table
            htmlPDFFile += "</tbody></table>";

            // Create the needed objects
            Stream reportStream;
            SaveFileDialog sfdReport = new SaveFileDialog();

            // Set the SaveFileDialog Options
            sfdReport.Filter = "PDF Files (*.PDF)|*.pdf";
            sfdReport.FileName = new String(("Courses Report (" + DateTime.Now.ToShortDateString() + ") Student Content Management System").ToCharArray()).Replace(" ", "_").Replace("/", "-") + ".pdf";
            sfdReport.Title = "Save Course Report";
            sfdReport.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Perform the saving of the file
            // Check if the user wants to save the file
            if (sfdReport.ShowDialog() == DialogResult.OK) {
                // Check if open file and be made with the stream
                if ((reportStream = sfdReport.OpenFile()) != null) {
                    // Copy the PDF stream to the reportStream
                    Renderer.RenderHtmlAsPdf(htmlPDFFile).Stream.CopyTo(reportStream);

                    // Close the stream
                    reportStream.Close();
                }
            }
        }
    }
}