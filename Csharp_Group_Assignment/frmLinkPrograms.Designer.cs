namespace Csharp_Group_Assignment {
    partial class frmLinkPrograms {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLinkPrograms));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.lblLinkTitle = new System.Windows.Forms.Label();
            this.cmbPrograms = new System.Windows.Forms.ComboBox();
            this.cmbLink = new System.Windows.Forms.ComboBox();
            this.grbLinks = new System.Windows.Forms.GroupBox();
            this.tlpLinks = new System.Windows.Forms.TableLayoutPanel();
            this.programTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.ProgramTableAdapter();
            this.courseProgramTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.CourseProgramTableAdapter();
            this.professorCourseTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.ProfessorCourseTableAdapter();
            this.studentCourseTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.StudentCourseTableAdapter();
            this.studentTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.StudentTableAdapter();
            this.professorTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.ProfessorTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.coursesTableAdapter1 = new Csharp_Group_Assignment.dtsAllTableAdapters.CoursesTableAdapter();
            this.studentProgramTableAdapter1 = new Csharp_Group_Assignment.dtsAllTableAdapters.StudentProgramTableAdapter();
            this.grbLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(98, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Form Title";
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramTitle.Location = new System.Drawing.Point(8, 53);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(76, 20);
            this.lblProgramTitle.TabIndex = 1;
            this.lblProgramTitle.Text = "Program";
            // 
            // lblLinkTitle
            // 
            this.lblLinkTitle.AutoSize = true;
            this.lblLinkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkTitle.Location = new System.Drawing.Point(221, 53);
            this.lblLinkTitle.Name = "lblLinkTitle";
            this.lblLinkTitle.Size = new System.Drawing.Size(81, 20);
            this.lblLinkTitle.TabIndex = 2;
            this.lblLinkTitle.Text = "Link Title";
            // 
            // cmbPrograms
            // 
            this.cmbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrograms.FormattingEnabled = true;
            this.cmbPrograms.Location = new System.Drawing.Point(12, 76);
            this.cmbPrograms.Name = "cmbPrograms";
            this.cmbPrograms.Size = new System.Drawing.Size(190, 21);
            this.cmbPrograms.TabIndex = 3;
            // 
            // cmbLink
            // 
            this.cmbLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLink.FormattingEnabled = true;
            this.cmbLink.Location = new System.Drawing.Point(225, 76);
            this.cmbLink.Name = "cmbLink";
            this.cmbLink.Size = new System.Drawing.Size(190, 21);
            this.cmbLink.TabIndex = 4;
            // 
            // grbLinks
            // 
            this.grbLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLinks.Controls.Add(this.tlpLinks);
            this.grbLinks.Location = new System.Drawing.Point(12, 142);
            this.grbLinks.Name = "grbLinks";
            this.grbLinks.Size = new System.Drawing.Size(403, 349);
            this.grbLinks.TabIndex = 5;
            this.grbLinks.TabStop = false;
            // 
            // tlpLinks
            // 
            this.tlpLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLinks.AutoScroll = true;
            this.tlpLinks.ColumnCount = 3;
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLinks.Location = new System.Drawing.Point(6, 19);
            this.tlpLinks.Name = "tlpLinks";
            this.tlpLinks.RowCount = 1;
            this.tlpLinks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLinks.Size = new System.Drawing.Size(391, 324);
            this.tlpLinks.TabIndex = 0;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // courseProgramTableAdapter
            // 
            this.courseProgramTableAdapter.ClearBeforeFill = true;
            // 
            // professorCourseTableAdapter
            // 
            this.professorCourseTableAdapter.ClearBeforeFill = true;
            // 
            // studentCourseTableAdapter
            // 
            this.studentCourseTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(332, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.Color.White;
            this.btnLink.Location = new System.Drawing.Point(12, 107);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(403, 31);
            this.btnLink.TabIndex = 9;
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // studentProgramTableAdapter1
            // 
            this.studentProgramTableAdapter1.ClearBeforeFill = true;
            // 
            // frmLinkPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(427, 533);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbLinks);
            this.Controls.Add(this.cmbLink);
            this.Controls.Add(this.cmbPrograms);
            this.Controls.Add(this.lblLinkTitle);
            this.Controls.Add(this.lblProgramTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinkPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLink_Load);
            this.grbLinks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Label lblLinkTitle;
        private System.Windows.Forms.ComboBox cmbPrograms;
        private System.Windows.Forms.ComboBox cmbLink;
        private System.Windows.Forms.GroupBox grbLinks;
        private System.Windows.Forms.TableLayoutPanel tlpLinks;
        private dtsAllTableAdapters.ProgramTableAdapter programTableAdapter;
        private dtsAllTableAdapters.CourseProgramTableAdapter courseProgramTableAdapter;
        private dtsAllTableAdapters.ProfessorCourseTableAdapter professorCourseTableAdapter;
        private dtsAllTableAdapters.StudentCourseTableAdapter studentCourseTableAdapter;
        private dtsAllTableAdapters.StudentTableAdapter studentTableAdapter;
        private dtsAllTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLink;
        private dtsAllTableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private dtsAllTableAdapters.StudentProgramTableAdapter studentProgramTableAdapter1;
    }
}