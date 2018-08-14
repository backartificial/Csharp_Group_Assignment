/**
 * 
 * File: frmLinkPrograms.cs
 * Developer: Emily Ramanna
 * Student Number: 991430310
 * Date: August 11, 2018
 * 
 * 
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;

namespace Csharp_Group_Assignment
{
    public partial class frmProgramsReport : Form
    {
        // Define needed class variable
        
        frmPrograms progFrm;

        public frmProgramsReport(frmPrograms progForm)
        {
            InitializeComponent();
            this.progFrm = progForm;
        }

        private void frmProgramsReport_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in progFrm.dtsAllData.Program)
            {
                // Add the program to the combobox
                cmbPrograms.Items.Add(new Programs(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["duration"].ToString()), char.Parse(row["coop"].ToString()), row["outcome"].ToString()));
            }
            cmbPrograms.SelectedIndex = 0;
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            //Fill the adapter
            programTableAdapter1.Fill(progFrm.dtsAllData.Program);

            // Sort the DataSetViews by course id
            // Course-Program Data View
            DataView programView = new DataView(progFrm.dtsAllData.Program);
            programView.Sort = "id ASC";

            // Create the needed rendering variable
            HtmlToPdf Renderer = new HtmlToPdf();

            // Set rendering options
            Renderer.PrintOptions.Title = "All Programs Report - " + DateTime.Now.ToLongDateString();
            Renderer.PrintOptions.DPI = 600;

            // Header Options
            Renderer.PrintOptions.FirstPageNumber = 1;
            Renderer.PrintOptions.Header.DrawDividerLine = true;
            Renderer.PrintOptions.Header.LeftText = "All Programs - " + DateTime.Now.ToLongDateString();
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

            // Add in the Programs Table
            htmlPDFFile += "<h3>Programs Information<h3><table style='width:100%;'>" +
                                "<thead>" +
                                    "<tr>" +
                                        "<th>Program Id</th>" +
                                        "<th>Program Name</th>" +
                                        "<th>Duration</th>" +
                                        "<th>Co-op Option</th>" +
                                        "<th>Outcome</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>";

            // Loop throug each program
            foreach (DataRow row in progFrm.dtsAllData.Program)
            {
                // Create a new Program instance with the correct information
                Programs rowProgram = new Programs(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["duration"].ToString()), char.Parse(row["coop"].ToString()), row["outcome"].ToString());

                // Hold Real Coop Value
                string coop = (rowProgram.coop.ToString().Equals("0")) ? "No" : "Yes";


                // Add the program to the table
                htmlPDFFile += "<tr>" +
                                    "<td>" + rowProgram.id + "</td>" +
                                    "<td>" + rowProgram.name + "</td>" +
                                    "<td>" + rowProgram.duration + " months</td>" +
                                    "<td>" + coop + "</td>" +
                                    "<td>" + rowProgram.outcome + "</td>" +
                                "</tr>";
            }

            // Close Program Table
            htmlPDFFile += "</tbody></table>";

            // Create the needed objects
            System.IO.Stream reportStream;
            SaveFileDialog sfdReport = new SaveFileDialog();

            // Set the SaveFileDialog Options
            sfdReport.Filter = "PDF Files (*.PDF)|*.pdf";
            sfdReport.FileName = new String(("Programs Report (" + DateTime.Now.ToShortDateString() + ") Student Content Management System").ToCharArray()).Replace(" ", "_").Replace("/", "-") + ".pdf";
            sfdReport.Title = "Save Program Report";
            sfdReport.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Perform the saving of the file
            // Check if the user wants to save the file
            if (sfdReport.ShowDialog() == DialogResult.OK)
            {
                // Check if open file and be made with the stream
                if ((reportStream = sfdReport.OpenFile()) != null)
                {
                    // Copy the PDF stream to the reportStream
                    Renderer.RenderHtmlAsPdf(htmlPDFFile).Stream.CopyTo(reportStream);

                    // Close the stream
                    reportStream.Close();
                    MessageBox.Show("Report Successfully Generated!");
                }
            }


        }

        private void btnProgSpecRep_Click(object sender, EventArgs e)
        {
            if(!rdbLinkedCourses.Checked && !rdbLinkedStudents.Checked)
            {
                MessageBox.Show("Please select a report first before trying to generate.");
            } else
            {
                //generates report showing all courses in a program
                if (rdbLinkedCourses.Checked)
                {
                    SqlDataAdapter datAdap;
                    DataSet ds = new DataSet();
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString))
                    {
                        // Open the DB connection
                        connection.Open();

                        
                        string queryString = "SELECT courses.id, coursecode, courses.name, location, time, capacity, credits FROM Courses INNER JOIN CourseProgram ON Courses.id = CourseProgram.courseId INNER JOIN Program ON CourseProgram.programId = Program.id  WHERE program.name = '" + cmbPrograms.SelectedItem.ToString() + "';";

                        try
                        {
                            datAdap = new SqlDataAdapter(queryString, connection);
                            datAdap.Fill(ds, "Courses");
                        } catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        

                    }

                    // Create the needed rendering variable
                    HtmlToPdf Renderer = new HtmlToPdf();

                    // Set rendering options
                    Renderer.PrintOptions.Title = "All Courses For: " + cmbPrograms.SelectedItem.ToString() +" - " + DateTime.Now.ToLongDateString();
                    Renderer.PrintOptions.DPI = 600;

                    // Header Options
                    Renderer.PrintOptions.FirstPageNumber = 1;
                    Renderer.PrintOptions.Header.DrawDividerLine = true;
                    Renderer.PrintOptions.Header.LeftText = "All Courses For: " + cmbPrograms.SelectedItem.ToString() + " - " + DateTime.Now.ToLongDateString();
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
                    foreach (DataRow row in ds.Tables["Courses"].Rows)
                    {
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
                    // Create the needed objects
                    System.IO.Stream reportStream;
                    SaveFileDialog sfdReport = new SaveFileDialog();

                    // Set the SaveFileDialog Options
                    sfdReport.Filter = "PDF Files (*.PDF)|*.pdf";
                    sfdReport.FileName = new String(("Programs Report (" + DateTime.Now.ToShortDateString() + ") Student Content Management System").ToCharArray()).Replace(" ", "_").Replace("/", "-") + ".pdf";
                    sfdReport.Title = "Save Program Report";
                    sfdReport.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    // Perform the saving of the file
                    // Check if the user wants to save the file
                    if (sfdReport.ShowDialog() == DialogResult.OK)
                    {
                        // Check if open file and be made with the stream
                        if ((reportStream = sfdReport.OpenFile()) != null)
                        {
                            // Copy the PDF stream to the reportStream
                            Renderer.RenderHtmlAsPdf(htmlPDFFile).Stream.CopyTo(reportStream);

                            // Close the stream
                            reportStream.Close();
                            MessageBox.Show("Report Successfully Generated!");
                        }
                    }


                }

                //generates report showing students registered in a program
                else if (rdbLinkedStudents.Checked)
                {
                    SqlDataAdapter datAdap;
                    DataSet ds = new DataSet();
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentManagerDBConnectionString))
                    {
                        // Open the DB connection
                        connection.Open();


                        string queryString = "SELECT student.id, studentNumber, firstName, lastName, birthday, gender, startDate FROM Student INNER JOIN StudentProgram ON Student.id = StudentProgram.studentId INNER JOIN Program ON StudentProgram.programId = Program.id  WHERE program.name = '" + cmbPrograms.SelectedItem.ToString() + "';";

                        try
                        {
                            datAdap = new SqlDataAdapter(queryString, connection);
                            datAdap.Fill(ds, "Students");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }

                    // Create the needed rendering variable
                    HtmlToPdf Renderer = new HtmlToPdf();

                    // Set rendering options
                    Renderer.PrintOptions.Title = "All Students Registered in: " + cmbPrograms.SelectedItem.ToString() + " - " + DateTime.Now.ToLongDateString();
                    Renderer.PrintOptions.DPI = 600;

                    // Header Options
                    Renderer.PrintOptions.FirstPageNumber = 1;
                    Renderer.PrintOptions.Header.DrawDividerLine = true;
                    Renderer.PrintOptions.Header.LeftText = "All Students Registered in: " + cmbPrograms.SelectedItem.ToString() + " - " + DateTime.Now.ToLongDateString();
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

                    // Add in the Courses Table
                    htmlPDFFile += "<h3>Student Information<h3><table style='width:100%;'>" +
                                        "<thead>" +
                                            "<tr>" +
                                                "<th>Student Id</th>" +
                                                "<th>Student Number</th>" +
                                                "<th>First Name</th>" +
                                                "<th>Last Location</th>" +
                                                "<th>Birthday</th>" +
                                                "<th>Gender</th>" +
                                                "<th>Start Date</th>" +
                                            "</tr>" +
                                        "</thead>" +
                                        "<tbody>";
                    foreach (DataRow row in ds.Tables["Students"].Rows)
                    {
                        // Create a new Course instance with the correct information
                        Student rowStudent = new Student(int.Parse(row["id"].ToString()), int.Parse(row["studentNumber"].ToString()), row["firstName"].ToString(), row["lastName"].ToString(), DateTime.Parse(row["birthday"].ToString()), char.Parse(row["gender"].ToString()), DateTime.Parse(row["startDate"].ToString()));

                        // Add the course to the table
                        htmlPDFFile += "<tr>" +
                                            "<td>" + rowStudent.id + "</td>" +
                                            "<td>" + rowStudent.studentNumber + "</td>" +
                                            "<td>" + rowStudent.firstName + "</td>" +
                                            "<td>" + rowStudent.lastName + "</td>" +
                                            "<td>" + rowStudent.birthday + "</td>" +
                                            "<td>" + rowStudent.gender + "</td>" +
                                            "<td>" + rowStudent.startDate + "</td>" +
                                        "</tr>";
                    }

                    // Close Course Table
                    htmlPDFFile += "</tbody></table>";
                    // Create the needed objects
                    System.IO.Stream reportStream;
                    SaveFileDialog sfdReport = new SaveFileDialog();

                    // Set the SaveFileDialog Options
                    sfdReport.Filter = "PDF Files (*.PDF)|*.pdf";
                    sfdReport.FileName = new String(("Programs Report (" + DateTime.Now.ToShortDateString() + ") Student Content Management System").ToCharArray()).Replace(" ", "_").Replace("/", "-") + ".pdf";
                    sfdReport.Title = "Save Program Report";
                    sfdReport.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    // Perform the saving of the file
                    // Check if the user wants to save the file
                    if (sfdReport.ShowDialog() == DialogResult.OK)
                    {
                        // Check if open file and be made with the stream
                        if ((reportStream = sfdReport.OpenFile()) != null)
                        {
                            // Copy the PDF stream to the reportStream
                            Renderer.RenderHtmlAsPdf(htmlPDFFile).Stream.CopyTo(reportStream);

                            // Close the stream
                            reportStream.Close();
                            MessageBox.Show("Report Successfully Generated!");
                        }
                    }
                }
            }
        }
    }
}
