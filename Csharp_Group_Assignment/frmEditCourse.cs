using System;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmEditCourse : Form {
        private DataGridViewRow courseRow;


        public frmEditCourse(DataGridViewRow courseRow) {
            InitializeComponent();

            this.courseRow = courseRow;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Form
            Close();
        }

        private void frmEditCourse_Load(object sender, EventArgs e) {

        }
    }
}
