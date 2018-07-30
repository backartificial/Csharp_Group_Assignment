namespace Csharp_Group_Assignment {
    partial class frmRemoveCoruse {
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiagree = new System.Windows.Forms.Label();
            this.lblAgree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to remove that Course?";
            // 
            // lblDiagree
            // 
            this.lblDiagree.AutoSize = true;
            this.lblDiagree.BackColor = System.Drawing.Color.White;
            this.lblDiagree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDiagree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblDiagree.Location = new System.Drawing.Point(171, 94);
            this.lblDiagree.Name = "lblDiagree";
            this.lblDiagree.Size = new System.Drawing.Size(107, 26);
            this.lblDiagree.TabIndex = 1;
            this.lblDiagree.Text = "Disagree";
            this.lblDiagree.Click += new System.EventHandler(this.lblDiagree_Click);
            // 
            // lblAgree
            // 
            this.lblAgree.AutoSize = true;
            this.lblAgree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(232)))));
            this.lblAgree.Location = new System.Drawing.Point(284, 94);
            this.lblAgree.Name = "lblAgree";
            this.lblAgree.Size = new System.Drawing.Size(75, 26);
            this.lblAgree.TabIndex = 2;
            this.lblAgree.Text = "Agree";
            this.lblAgree.Click += new System.EventHandler(this.lblAgree_Click);
            // 
            // frmRemoveCoruse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 129);
            this.Controls.Add(this.lblAgree);
            this.Controls.Add(this.lblDiagree);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRemoveCoruse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Course | Student Content Management Ssystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiagree;
        private System.Windows.Forms.Label lblAgree;
    }
}