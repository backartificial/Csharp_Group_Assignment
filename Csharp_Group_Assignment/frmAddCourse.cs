using System;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmAddCourse : Form {
        public frmAddCourse() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Add Course Form
            Close();
        }
    }
}
