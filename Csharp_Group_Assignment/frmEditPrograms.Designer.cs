namespace Csharp_Group_Assignment {
    partial class frmEditPrograms {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditProgram = new System.Windows.Forms.Button();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCoop = new System.Windows.Forms.Label();
            this.chkbxCoop = new System.Windows.Forms.CheckBox();
            this.lblCoopHelper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(172, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditProgram
            // 
            this.btnEditProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEditProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProgram.FlatAppearance.BorderSize = 0;
            this.btnEditProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnEditProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnEditProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProgram.ForeColor = System.Drawing.Color.White;
            this.btnEditProgram.Location = new System.Drawing.Point(262, 196);
            this.btnEditProgram.Name = "btnEditProgram";
            this.btnEditProgram.Size = new System.Drawing.Size(83, 31);
            this.btnEditProgram.TabIndex = 4;
            this.btnEditProgram.Text = "Save";
            this.btnEditProgram.UseVisualStyleBackColor = false;
            this.btnEditProgram.Click += new System.EventHandler(this.btnEditProgram_Click);
            // 
            // txtProgramName
            // 
            this.txtProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProgramName.Location = new System.Drawing.Point(135, 54);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.ReadOnly = true;
            this.txtProgramName.Size = new System.Drawing.Size(215, 26);
            this.txtProgramName.TabIndex = 99;
            // 
            // txtOutcome
            // 
            this.txtOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOutcome.Location = new System.Drawing.Point(135, 152);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Size = new System.Drawing.Size(215, 26);
            this.txtOutcome.TabIndex = 3;
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuration.Location = new System.Drawing.Point(135, 90);
            this.nudDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(215, 26);
            this.nudDuration.TabIndex = 1;
            this.nudDuration.ThousandsSeparator = true;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(51, 92);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(78, 20);
            this.lblDuration.TabIndex = 21;
            this.lblDuration.Text = "Duration";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(48, 155);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(81, 20);
            this.lblOutcome.TabIndex = 19;
            this.lblOutcome.Text = "Outcome";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(2, 57);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(127, 20);
            this.lblProgramName.TabIndex = 17;
            this.lblProgramName.Text = "Program Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(95, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Edit Program";
            // 
            // lblCoop
            // 
            this.lblCoop.AutoSize = true;
            this.lblCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoop.Location = new System.Drawing.Point(63, 123);
            this.lblCoop.Name = "lblCoop";
            this.lblCoop.Size = new System.Drawing.Size(57, 20);
            this.lblCoop.TabIndex = 100;
            this.lblCoop.Text = "Co-op";
            // 
            // chkbxCoop
            // 
            this.chkbxCoop.AutoSize = true;
            this.chkbxCoop.Location = new System.Drawing.Point(135, 128);
            this.chkbxCoop.Name = "chkbxCoop";
            this.chkbxCoop.Size = new System.Drawing.Size(15, 14);
            this.chkbxCoop.TabIndex = 2;
            this.chkbxCoop.UseVisualStyleBackColor = true;
            // 
            // lblCoopHelper
            // 
            this.lblCoopHelper.AutoSize = true;
            this.lblCoopHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCoopHelper.Location = new System.Drawing.Point(156, 123);
            this.lblCoopHelper.Name = "lblCoopHelper";
            this.lblCoopHelper.Size = new System.Drawing.Size(85, 20);
            this.lblCoopHelper.TabIndex = 101;
            this.lblCoopHelper.Text = "Has Co-op";
            // 
            // frmEditPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(357, 255);
            this.Controls.Add(this.lblCoopHelper);
            this.Controls.Add(this.chkbxCoop);
            this.Controls.Add(this.lblCoop);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditProgram);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.txtOutcome);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Program | Student Content Management System";
            this.Load += new System.EventHandler(this.frmEditProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditProgram;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCoop;
        private System.Windows.Forms.CheckBox chkbxCoop;
        private System.Windows.Forms.Label lblCoopHelper;
    }
}