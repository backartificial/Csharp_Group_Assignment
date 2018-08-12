namespace Csharp_Group_Assignment {
    partial class frmLink {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLink));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lblLinkTitle = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbLink = new System.Windows.Forms.ComboBox();
            this.grbLinks = new System.Windows.Forms.GroupBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.tlpLinks = new System.Windows.Forms.TableLayoutPanel();
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
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(12, 53);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(66, 20);
            this.lblCourseTitle.TabIndex = 1;
            this.lblCourseTitle.Text = "Course";
            // 
            // lblLinkTitle
            // 
            this.lblLinkTitle.AutoSize = true;
            this.lblLinkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkTitle.Location = new System.Drawing.Point(185, 53);
            this.lblLinkTitle.Name = "lblLinkTitle";
            this.lblLinkTitle.Size = new System.Drawing.Size(81, 20);
            this.lblLinkTitle.TabIndex = 2;
            this.lblLinkTitle.Text = "Link Title";
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(16, 77);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(141, 21);
            this.cmbCourses.TabIndex = 3;
            // 
            // cmbLink
            // 
            this.cmbLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLink.FormattingEnabled = true;
            this.cmbLink.Location = new System.Drawing.Point(189, 77);
            this.cmbLink.Name = "cmbLink";
            this.cmbLink.Size = new System.Drawing.Size(141, 21);
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
            this.grbLinks.Size = new System.Drawing.Size(318, 379);
            this.grbLinks.TabIndex = 5;
            this.grbLinks.TabStop = false;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(16, 109);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(314, 31);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "Link";
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // tlpLinks
            // 
            this.tlpLinks.ColumnCount = 3;
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLinks.Location = new System.Drawing.Point(6, 19);
            this.tlpLinks.Name = "tlpLinks";
            this.tlpLinks.RowCount = 1;
            this.tlpLinks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLinks.Size = new System.Drawing.Size(306, 354);
            this.tlpLinks.TabIndex = 0;
            // 
            // frmLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 533);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.grbLinks);
            this.Controls.Add(this.cmbLink);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.lblLinkTitle);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLink";
            this.Load += new System.EventHandler(this.frmLink_Load);
            this.grbLinks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblLinkTitle;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbLink;
        private System.Windows.Forms.GroupBox grbLinks;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.TableLayoutPanel tlpLinks;
    }
}