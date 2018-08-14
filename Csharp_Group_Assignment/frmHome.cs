using System;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {
    public partial class frmHome : Form {
        public frmHome() {
            InitializeComponent();
        }

        private void btnNavStudents_Click(object sender, EventArgs e) {
            FormsGlobal.frmStudentsAndProfessors.Show();
        }
    }
}
