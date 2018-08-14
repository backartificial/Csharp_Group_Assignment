namespace Csharp_Group_Assignment {
    partial class frmAddPrograms {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPrograms));
            this.lblAddCourseTitle = new System.Windows.Forms.Label();
            this.lblAddProgramProgName = new System.Windows.Forms.Label();
            this.lblAddProgramOutcome = new System.Windows.Forms.Label();
            this.lblAddProgramCoop = new System.Windows.Forms.Label();
            this.lblAddProgramDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.txtProgramOutcome = new System.Windows.Forms.TextBox();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnAddAnotherProgram = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkbxCoop = new System.Windows.Forms.CheckBox();
            this.lblCoopHelper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCourseTitle
            // 
            this.lblAddCourseTitle.AutoSize = true;
            this.lblAddCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseTitle.Location = new System.Drawing.Point(80, 9);
            this.lblAddCourseTitle.Name = "lblAddCourseTitle";
            this.lblAddCourseTitle.Size = new System.Drawing.Size(183, 31);
            this.lblAddCourseTitle.TabIndex = 0;
            this.lblAddCourseTitle.Text = "Add Program";
            // 
            // lblAddProgramProgName
            // 
            this.lblAddProgramProgName.AutoSize = true;
            this.lblAddProgramProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProgramProgName.Location = new System.Drawing.Point(2, 57);
            this.lblAddProgramProgName.Name = "lblAddProgramProgName";
            this.lblAddProgramProgName.Size = new System.Drawing.Size(127, 20);
            this.lblAddProgramProgName.TabIndex = 1;
            this.lblAddProgramProgName.Text = "Program Name";
            // 
            // lblAddProgramOutcome
            // 
            this.lblAddProgramOutcome.AutoSize = true;
            this.lblAddProgramOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProgramOutcome.Location = new System.Drawing.Point(48, 160);
            this.lblAddProgramOutcome.Name = "lblAddProgramOutcome";
            this.lblAddProgramOutcome.Size = new System.Drawing.Size(81, 20);
            this.lblAddProgramOutcome.TabIndex = 2;
            this.lblAddProgramOutcome.Text = "Outcome";
            // 
            // lblAddProgramCoop
            // 
            this.lblAddProgramCoop.AutoSize = true;
            this.lblAddProgramCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProgramCoop.Location = new System.Drawing.Point(72, 127);
            this.lblAddProgramCoop.Name = "lblAddProgramCoop";
            this.lblAddProgramCoop.Size = new System.Drawing.Size(57, 20);
            this.lblAddProgramCoop.TabIndex = 4;
            this.lblAddProgramCoop.Text = "Co-op";
            // 
            // lblAddProgramDuration
            // 
            this.lblAddProgramDuration.AutoSize = true;
            this.lblAddProgramDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProgramDuration.Location = new System.Drawing.Point(51, 93);
            this.lblAddProgramDuration.Name = "lblAddProgramDuration";
            this.lblAddProgramDuration.Size = new System.Drawing.Size(78, 20);
            this.lblAddProgramDuration.TabIndex = 5;
            this.lblAddProgramDuration.Text = "Duration";
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuration.Location = new System.Drawing.Point(135, 91);
            this.nudDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(215, 26);
            this.nudDuration.TabIndex = 5;
            this.nudDuration.ThousandsSeparator = true;
            // 
            // txtProgramOutcome
            // 
            this.txtProgramOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProgramOutcome.Location = new System.Drawing.Point(135, 160);
            this.txtProgramOutcome.MaxLength = 50;
            this.txtProgramOutcome.Name = "txtProgramOutcome";
            this.txtProgramOutcome.Size = new System.Drawing.Size(215, 26);
            this.txtProgramOutcome.TabIndex = 2;
            // 
            // txtProgramName
            // 
            this.txtProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProgramName.Location = new System.Drawing.Point(135, 54);
            this.txtProgramName.MaxLength = 100;
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(215, 26);
            this.txtProgramName.TabIndex = 1;
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAddProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProgram.FlatAppearance.BorderSize = 0;
            this.btnAddProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnAddProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProgram.ForeColor = System.Drawing.Color.White;
            this.btnAddProgram.Location = new System.Drawing.Point(267, 208);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(83, 31);
            this.btnAddProgram.TabIndex = 7;
            this.btnAddProgram.Text = "Add Course";
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnAddAnotherProgram
            // 
            this.btnAddAnotherProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnAddAnotherProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnotherProgram.FlatAppearance.BorderSize = 0;
            this.btnAddAnotherProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(102)))), ((int)(((byte)(116)))));
            this.btnAddAnotherProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(102)))), ((int)(((byte)(116)))));
            this.btnAddAnotherProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnotherProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherProgram.ForeColor = System.Drawing.Color.White;
            this.btnAddAnotherProgram.Location = new System.Drawing.Point(135, 208);
            this.btnAddAnotherProgram.Name = "btnAddAnotherProgram";
            this.btnAddAnotherProgram.Size = new System.Drawing.Size(126, 31);
            this.btnAddAnotherProgram.TabIndex = 8;
            this.btnAddAnotherProgram.Text = "Add Another ";
            this.btnAddAnotherProgram.UseVisualStyleBackColor = false;
            this.btnAddAnotherProgram.Click += new System.EventHandler(this.btnAddAnotherProgram_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(42)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(42)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(46, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkbxCoop
            // 
            this.chkbxCoop.AutoSize = true;
            this.chkbxCoop.Location = new System.Drawing.Point(135, 130);
            this.chkbxCoop.Name = "chkbxCoop";
            this.chkbxCoop.Size = new System.Drawing.Size(15, 14);
            this.chkbxCoop.TabIndex = 10;
            this.chkbxCoop.UseVisualStyleBackColor = true;
            // 
            // lblCoopHelper
            // 
            this.lblCoopHelper.AutoSize = true;
            this.lblCoopHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCoopHelper.Location = new System.Drawing.Point(156, 127);
            this.lblCoopHelper.Name = "lblCoopHelper";
            this.lblCoopHelper.Size = new System.Drawing.Size(85, 20);
            this.lblCoopHelper.TabIndex = 11;
            this.lblCoopHelper.Text = "Has Co-op";
            // 
            // frmAddPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(357, 262);
            this.Controls.Add(this.lblCoopHelper);
            this.Controls.Add(this.chkbxCoop);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAnotherProgram);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.txtProgramOutcome);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lblAddProgramDuration);
            this.Controls.Add(this.lblAddProgramCoop);
            this.Controls.Add(this.lblAddProgramOutcome);
            this.Controls.Add(this.lblAddProgramProgName);
            this.Controls.Add(this.lblAddCourseTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPrograms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Program | Student Content Management System";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCourseTitle;
        private System.Windows.Forms.Label lblAddProgramProgName;
        private System.Windows.Forms.Label lblAddProgramOutcome;
        private System.Windows.Forms.Label lblAddProgramCoop;
        private System.Windows.Forms.Label lblAddProgramDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.TextBox txtProgramOutcome;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnAddAnotherProgram;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkbxCoop;
        private System.Windows.Forms.Label lblCoopHelper;
    }
}