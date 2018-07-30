using System;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmCourses : Form {
        public frmCourses() {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'studentManagerDBDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManagerDBDataSet.Courses);

        }

        private void btnLinkCourse_MouseEnter(object sender, EventArgs e) {
            pnlBtnLinkOption.Visible = true;
        }

        private void frmCourses_MouseEnter(object sender, EventArgs e) {
            pnlBtnLinkOption.Visible = false;
        }

        private void dgvCourses_MouseEnter(object sender, EventArgs e) {
            pnlBtnLinkOption.Visible = false;
        }
    }
}
