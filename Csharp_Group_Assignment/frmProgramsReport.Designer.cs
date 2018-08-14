namespace Csharp_Group_Assignment
{
    partial class frmProgramsReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgramsReport));
            this.grpbxGenRep = new System.Windows.Forms.GroupBox();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.grpbxProgRepSpec = new System.Windows.Forms.GroupBox();
            this.btnProgSpecRep = new System.Windows.Forms.Button();
            this.rdbLinkedStudents = new System.Windows.Forms.RadioButton();
            this.rdbLinkedCourses = new System.Windows.Forms.RadioButton();
            this.lblProgName = new System.Windows.Forms.Label();
            this.cmbPrograms = new System.Windows.Forms.ComboBox();
            this.programTableAdapter1 = new Csharp_Group_Assignment.dtsAllTableAdapters.ProgramTableAdapter();
            this.grpbxGenRep.SuspendLayout();
            this.grpbxProgRepSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxGenRep
            // 
            this.grpbxGenRep.Controls.Add(this.btnGenRep);
            this.grpbxGenRep.Location = new System.Drawing.Point(115, 23);
            this.grpbxGenRep.Name = "grpbxGenRep";
            this.grpbxGenRep.Size = new System.Drawing.Size(200, 100);
            this.grpbxGenRep.TabIndex = 0;
            this.grpbxGenRep.TabStop = false;
            this.grpbxGenRep.Text = "General Report";
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(44, 34);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(120, 41);
            this.btnGenRep.TabIndex = 0;
            this.btnGenRep.Text = "Print General Program Report";
            this.btnGenRep.UseVisualStyleBackColor = true;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // grpbxProgRepSpec
            // 
            this.grpbxProgRepSpec.Controls.Add(this.btnProgSpecRep);
            this.grpbxProgRepSpec.Controls.Add(this.rdbLinkedStudents);
            this.grpbxProgRepSpec.Controls.Add(this.rdbLinkedCourses);
            this.grpbxProgRepSpec.Controls.Add(this.lblProgName);
            this.grpbxProgRepSpec.Controls.Add(this.cmbPrograms);
            this.grpbxProgRepSpec.Location = new System.Drawing.Point(115, 152);
            this.grpbxProgRepSpec.Name = "grpbxProgRepSpec";
            this.grpbxProgRepSpec.Size = new System.Drawing.Size(200, 245);
            this.grpbxProgRepSpec.TabIndex = 1;
            this.grpbxProgRepSpec.TabStop = false;
            this.grpbxProgRepSpec.Text = "Program Specific Reports";
            // 
            // btnProgSpecRep
            // 
            this.btnProgSpecRep.Location = new System.Drawing.Point(55, 174);
            this.btnProgSpecRep.Name = "btnProgSpecRep";
            this.btnProgSpecRep.Size = new System.Drawing.Size(87, 41);
            this.btnProgSpecRep.TabIndex = 2;
            this.btnProgSpecRep.Text = "Generate Report";
            this.btnProgSpecRep.UseVisualStyleBackColor = true;
            this.btnProgSpecRep.Click += new System.EventHandler(this.btnProgSpecRep_Click);
            // 
            // rdbLinkedStudents
            // 
            this.rdbLinkedStudents.AutoSize = true;
            this.rdbLinkedStudents.Location = new System.Drawing.Point(44, 121);
            this.rdbLinkedStudents.Name = "rdbLinkedStudents";
            this.rdbLinkedStudents.Size = new System.Drawing.Size(102, 17);
            this.rdbLinkedStudents.TabIndex = 2;
            this.rdbLinkedStudents.TabStop = true;
            this.rdbLinkedStudents.Text = "Linked Students";
            this.rdbLinkedStudents.UseVisualStyleBackColor = true;
            // 
            // rdbLinkedCourses
            // 
            this.rdbLinkedCourses.AutoSize = true;
            this.rdbLinkedCourses.Location = new System.Drawing.Point(44, 88);
            this.rdbLinkedCourses.Name = "rdbLinkedCourses";
            this.rdbLinkedCourses.Size = new System.Drawing.Size(98, 17);
            this.rdbLinkedCourses.TabIndex = 1;
            this.rdbLinkedCourses.TabStop = true;
            this.rdbLinkedCourses.Text = "Linked Courses";
            this.rdbLinkedCourses.UseVisualStyleBackColor = true;
            // 
            // lblProgName
            // 
            this.lblProgName.AutoSize = true;
            this.lblProgName.Location = new System.Drawing.Point(16, 43);
            this.lblProgName.Name = "lblProgName";
            this.lblProgName.Size = new System.Drawing.Size(49, 13);
            this.lblProgName.TabIndex = 1;
            this.lblProgName.Text = "Program:";
            // 
            // cmbPrograms
            // 
            this.cmbPrograms.FormattingEnabled = true;
            this.cmbPrograms.Location = new System.Drawing.Point(73, 40);
            this.cmbPrograms.Name = "cmbPrograms";
            this.cmbPrograms.Size = new System.Drawing.Size(121, 21);
            this.cmbPrograms.TabIndex = 0;
            // 
            // programTableAdapter1
            // 
            this.programTableAdapter1.ClearBeforeFill = true;
            // 
            // frmProgramsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 426);
            this.Controls.Add(this.grpbxProgRepSpec);
            this.Controls.Add(this.grpbxGenRep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgramsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Program Report | Student Manager Report";
            this.Load += new System.EventHandler(this.frmProgramsReport_Load);
            this.grpbxGenRep.ResumeLayout(false);
            this.grpbxProgRepSpec.ResumeLayout(false);
            this.grpbxProgRepSpec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxGenRep;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.GroupBox grpbxProgRepSpec;
        private System.Windows.Forms.Button btnProgSpecRep;
        private System.Windows.Forms.RadioButton rdbLinkedStudents;
        private System.Windows.Forms.RadioButton rdbLinkedCourses;
        private System.Windows.Forms.Label lblProgName;
        private System.Windows.Forms.ComboBox cmbPrograms;
        private dtsAllTableAdapters.ProgramTableAdapter programTableAdapter1;
    }
}