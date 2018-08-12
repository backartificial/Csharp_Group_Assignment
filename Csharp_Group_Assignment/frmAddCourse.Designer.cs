namespace Csharp_Group_Assignment {
    partial class frmAddCourse {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCourse));
            this.lblAddCourseTitle = new System.Windows.Forms.Label();
            this.lblAddCourseCourseCode = new System.Windows.Forms.Label();
            this.lblAddCourseCourseName = new System.Windows.Forms.Label();
            this.lblAddCourseLocation = new System.Windows.Forms.Label();
            this.lblAddCourseTime = new System.Windows.Forms.Label();
            this.lblAddCourseCapacity = new System.Windows.Forms.Label();
            this.lblAddCourseCredits = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnAddAnotherCourse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCourseTitle
            // 
            this.lblAddCourseTitle.AutoSize = true;
            this.lblAddCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseTitle.Location = new System.Drawing.Point(100, 9);
            this.lblAddCourseTitle.Name = "lblAddCourseTitle";
            this.lblAddCourseTitle.Size = new System.Drawing.Size(167, 31);
            this.lblAddCourseTitle.TabIndex = 0;
            this.lblAddCourseTitle.Text = "Add Course";
            // 
            // lblAddCourseCourseCode
            // 
            this.lblAddCourseCourseCode.AutoSize = true;
            this.lblAddCourseCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseCourseCode.Location = new System.Drawing.Point(16, 57);
            this.lblAddCourseCourseCode.Name = "lblAddCourseCourseCode";
            this.lblAddCourseCourseCode.Size = new System.Drawing.Size(113, 20);
            this.lblAddCourseCourseCode.TabIndex = 1;
            this.lblAddCourseCourseCode.Text = "Course Code";
            // 
            // lblAddCourseCourseName
            // 
            this.lblAddCourseCourseName.AutoSize = true;
            this.lblAddCourseCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseCourseName.Location = new System.Drawing.Point(12, 90);
            this.lblAddCourseCourseName.Name = "lblAddCourseCourseName";
            this.lblAddCourseCourseName.Size = new System.Drawing.Size(117, 20);
            this.lblAddCourseCourseName.TabIndex = 2;
            this.lblAddCourseCourseName.Text = "Course Name";
            // 
            // lblAddCourseLocation
            // 
            this.lblAddCourseLocation.AutoSize = true;
            this.lblAddCourseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseLocation.Location = new System.Drawing.Point(51, 123);
            this.lblAddCourseLocation.Name = "lblAddCourseLocation";
            this.lblAddCourseLocation.Size = new System.Drawing.Size(78, 20);
            this.lblAddCourseLocation.TabIndex = 3;
            this.lblAddCourseLocation.Text = "Location";
            // 
            // lblAddCourseTime
            // 
            this.lblAddCourseTime.AutoSize = true;
            this.lblAddCourseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseTime.Location = new System.Drawing.Point(82, 156);
            this.lblAddCourseTime.Name = "lblAddCourseTime";
            this.lblAddCourseTime.Size = new System.Drawing.Size(47, 20);
            this.lblAddCourseTime.TabIndex = 4;
            this.lblAddCourseTime.Text = "Time";
            // 
            // lblAddCourseCapacity
            // 
            this.lblAddCourseCapacity.AutoSize = true;
            this.lblAddCourseCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseCapacity.Location = new System.Drawing.Point(51, 181);
            this.lblAddCourseCapacity.Name = "lblAddCourseCapacity";
            this.lblAddCourseCapacity.Size = new System.Drawing.Size(78, 20);
            this.lblAddCourseCapacity.TabIndex = 5;
            this.lblAddCourseCapacity.Text = "Capacity";
            // 
            // lblAddCourseCredits
            // 
            this.lblAddCourseCredits.AutoSize = true;
            this.lblAddCourseCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseCredits.Location = new System.Drawing.Point(63, 214);
            this.lblAddCourseCredits.Name = "lblAddCourseCredits";
            this.lblAddCourseCredits.Size = new System.Drawing.Size(66, 20);
            this.lblAddCourseCredits.TabIndex = 6;
            this.lblAddCourseCredits.Text = "Credits";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCapacity.Location = new System.Drawing.Point(135, 184);
            this.nudCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(215, 26);
            this.nudCapacity.TabIndex = 5;
            this.nudCapacity.ThousandsSeparator = true;
            // 
            // nudCredits
            // 
            this.nudCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCredits.Location = new System.Drawing.Point(135, 217);
            this.nudCredits.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(215, 26);
            this.nudCredits.TabIndex = 6;
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(135, 151);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(215, 26);
            this.dtpTime.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLocation.Location = new System.Drawing.Point(135, 120);
            this.txtLocation.MaxLength = 50;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(215, 26);
            this.txtLocation.TabIndex = 3;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCourseName.Location = new System.Drawing.Point(135, 87);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(215, 26);
            this.txtCourseName.TabIndex = 2;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCourseCode.Location = new System.Drawing.Point(135, 54);
            this.txtCourseCode.MaxLength = 6;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(215, 26);
            this.txtCourseCode.TabIndex = 1;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnAddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(267, 261);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(83, 31);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnAddAnotherCourse
            // 
            this.btnAddAnotherCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnAddAnotherCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnotherCourse.FlatAppearance.BorderSize = 0;
            this.btnAddAnotherCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(102)))), ((int)(((byte)(116)))));
            this.btnAddAnotherCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(102)))), ((int)(((byte)(116)))));
            this.btnAddAnotherCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnotherCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddAnotherCourse.Location = new System.Drawing.Point(135, 261);
            this.btnAddAnotherCourse.Name = "btnAddAnotherCourse";
            this.btnAddAnotherCourse.Size = new System.Drawing.Size(126, 31);
            this.btnAddAnotherCourse.TabIndex = 8;
            this.btnAddAnotherCourse.Text = "Add Another Course";
            this.btnAddAnotherCourse.UseVisualStyleBackColor = false;
            this.btnAddAnotherCourse.Click += new System.EventHandler(this.btnAddAnotherCourse_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(46, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(357, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAnotherCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.lblAddCourseCredits);
            this.Controls.Add(this.lblAddCourseCapacity);
            this.Controls.Add(this.lblAddCourseTime);
            this.Controls.Add(this.lblAddCourseLocation);
            this.Controls.Add(this.lblAddCourseCourseName);
            this.Controls.Add(this.lblAddCourseCourseCode);
            this.Controls.Add(this.lblAddCourseTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCourse";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course | Student Content Management System";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCourseTitle;
        private System.Windows.Forms.Label lblAddCourseCourseCode;
        private System.Windows.Forms.Label lblAddCourseCourseName;
        private System.Windows.Forms.Label lblAddCourseLocation;
        private System.Windows.Forms.Label lblAddCourseTime;
        private System.Windows.Forms.Label lblAddCourseCapacity;
        private System.Windows.Forms.Label lblAddCourseCredits;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.NumericUpDown nudCredits;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddAnotherCourse;
        private System.Windows.Forms.Button btnCancel;
    }
}