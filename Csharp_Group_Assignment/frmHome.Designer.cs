namespace Csharp_Group_Assignment {
    partial class frmHome {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pnlNavButtons = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavProfessors = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnNavStudents = new System.Windows.Forms.Button();
            this.btnNavPrograms = new System.Windows.Forms.Button();
            this.pnlHelloMsgBackgroundColor = new System.Windows.Forms.Panel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.chtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlNavButtons.SuspendLayout();
            this.pnlHelloMsgBackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlLeftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftMenu.Controls.Add(this.pnlNavButtons);
            this.pnlLeftMenu.Controls.Add(this.pnlHelloMsgBackgroundColor);
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(242, 519);
            this.pnlLeftMenu.TabIndex = 1;
            // 
            // pnlNavButtons
            // 
            this.pnlNavButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNavButtons.Controls.Add(this.btnNavHome);
            this.pnlNavButtons.Controls.Add(this.btnNavProfessors);
            this.pnlNavButtons.Controls.Add(this.btnCourses);
            this.pnlNavButtons.Controls.Add(this.btnNavStudents);
            this.pnlNavButtons.Controls.Add(this.btnNavPrograms);
            this.pnlNavButtons.Location = new System.Drawing.Point(20, 119);
            this.pnlNavButtons.Name = "pnlNavButtons";
            this.pnlNavButtons.Size = new System.Drawing.Size(199, 268);
            this.pnlNavButtons.TabIndex = 6;
            // 
            // btnNavHome
            // 
            this.btnNavHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(114)))));
            this.btnNavHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(114)))));
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.ForeColor = System.Drawing.Color.White;
            this.btnNavHome.Location = new System.Drawing.Point(0, 0);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(199, 49);
            this.btnNavHome.TabIndex = 3;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = false;
            // 
            // btnNavProfessors
            // 
            this.btnNavProfessors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavProfessors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnNavProfessors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavProfessors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfessors.FlatAppearance.BorderSize = 0;
            this.btnNavProfessors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavProfessors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavProfessors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProfessors.ForeColor = System.Drawing.Color.White;
            this.btnNavProfessors.Location = new System.Drawing.Point(0, 220);
            this.btnNavProfessors.Name = "btnNavProfessors";
            this.btnNavProfessors.Size = new System.Drawing.Size(199, 49);
            this.btnNavProfessors.TabIndex = 5;
            this.btnNavProfessors.Text = "Professors";
            this.btnNavProfessors.UseVisualStyleBackColor = false;
            this.btnNavProfessors.Click += new System.EventHandler(this.btnNavProfessors_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(0, 110);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(199, 49);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnNavStudents
            // 
            this.btnNavStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnNavStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStudents.FlatAppearance.BorderSize = 0;
            this.btnNavStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavStudents.ForeColor = System.Drawing.Color.White;
            this.btnNavStudents.Location = new System.Drawing.Point(0, 165);
            this.btnNavStudents.Name = "btnNavStudents";
            this.btnNavStudents.Size = new System.Drawing.Size(199, 49);
            this.btnNavStudents.TabIndex = 4;
            this.btnNavStudents.Text = "Students";
            this.btnNavStudents.UseVisualStyleBackColor = false;
            this.btnNavStudents.Click += new System.EventHandler(this.btnNavStudents_Click);
            // 
            // btnNavPrograms
            // 
            this.btnNavPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnNavPrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPrograms.FlatAppearance.BorderSize = 0;
            this.btnNavPrograms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavPrograms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavPrograms.ForeColor = System.Drawing.Color.White;
            this.btnNavPrograms.Location = new System.Drawing.Point(0, 55);
            this.btnNavPrograms.Name = "btnNavPrograms";
            this.btnNavPrograms.Size = new System.Drawing.Size(199, 49);
            this.btnNavPrograms.TabIndex = 2;
            this.btnNavPrograms.Text = "Programs";
            this.btnNavPrograms.UseVisualStyleBackColor = false;
            this.btnNavPrograms.Click += new System.EventHandler(this.btnNavPrograms_Click);
            // 
            // pnlHelloMsgBackgroundColor
            // 
            this.pnlHelloMsgBackgroundColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHelloMsgBackgroundColor.BackColor = System.Drawing.Color.White;
            this.pnlHelloMsgBackgroundColor.Controls.Add(this.lblWelcomeMessage);
            this.pnlHelloMsgBackgroundColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHelloMsgBackgroundColor.Location = new System.Drawing.Point(0, 0);
            this.pnlHelloMsgBackgroundColor.Name = "pnlHelloMsgBackgroundColor";
            this.pnlHelloMsgBackgroundColor.Size = new System.Drawing.Size(240, 98);
            this.pnlHelloMsgBackgroundColor.TabIndex = 0;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.White;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(24, 40);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(199, 24);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Hello, Administrator!";
            // 
            // chtMain
            // 
            this.chtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chtMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtMain.Legends.Add(legend1);
            this.chtMain.Location = new System.Drawing.Point(248, 12);
            this.chtMain.Name = "chtMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtMain.Series.Add(series1);
            this.chtMain.Size = new System.Drawing.Size(540, 494);
            this.chtMain.TabIndex = 2;
            this.chtMain.Text = "chart1";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.chtMain);
            this.Controls.Add(this.pnlLeftMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home | Student Content Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlNavButtons.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Panel pnlNavButtons;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavProfessors;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnNavStudents;
        private System.Windows.Forms.Button btnNavPrograms;
        private System.Windows.Forms.Panel pnlHelloMsgBackgroundColor;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMain;
    }
}