namespace Csharp_Group_Assignment {
    partial class frmCourses {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlHelloMsgBackgroundColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagerDBDataSet = new Csharp_Group_Assignment.StudentManagerDBDataSet();
            this.coursesTableAdapter = new Csharp_Group_Assignment.StudentManagerDBDataSetTableAdapters.CoursesTableAdapter();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.ttpGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBtnLinkOption = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLinkCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnPrintCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnRemoveCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnEditCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnAddCourse = new Csharp_Group_Assignment.CircleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHelloMsgBackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagerDBDataSet)).BeginInit();
            this.pnlBtnLinkOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlHelloMsgBackgroundColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 571);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnCourses);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(20, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 268);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Professors";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            this.btnCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(114)))));
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(114)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(0, 110);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(199, 49);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Students";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Programs";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnlHelloMsgBackgroundColor
            // 
            this.pnlHelloMsgBackgroundColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHelloMsgBackgroundColor.BackColor = System.Drawing.Color.White;
            this.pnlHelloMsgBackgroundColor.Controls.Add(this.label1);
            this.pnlHelloMsgBackgroundColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHelloMsgBackgroundColor.Location = new System.Drawing.Point(0, 0);
            this.pnlHelloMsgBackgroundColor.Name = "pnlHelloMsgBackgroundColor";
            this.pnlHelloMsgBackgroundColor.Size = new System.Drawing.Size(240, 98);
            this.pnlHelloMsgBackgroundColor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, Administrator!";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn});
            this.dgvCourses.DataSource = this.coursesBindingSource;
            this.dgvCourses.Location = new System.Drawing.Point(248, 58);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.Size = new System.Drawing.Size(746, 501);
            this.dgvCourses.TabIndex = 1;
            this.dgvCourses.MouseEnter += new System.EventHandler(this.dgvCourses_MouseEnter);
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "courseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course Code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseCodeDataGridViewTextBoxColumn.Width = 93;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 73;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 55;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 73;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.studentManagerDBDataSet;
            // 
            // studentManagerDBDataSet
            // 
            this.studentManagerDBDataSet.DataSetName = "StudentManagerDBDataSet";
            this.studentManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnSearchCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCourse.FlatAppearance.BorderSize = 0;
            this.btnSearchCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnSearchCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnSearchCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCourse.ForeColor = System.Drawing.Color.White;
            this.btnSearchCourse.Location = new System.Drawing.Point(897, 16);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(97, 31);
            this.btnSearchCourse.TabIndex = 3;
            this.btnSearchCourse.Text = "Search";
            this.btnSearchCourse.UseVisualStyleBackColor = false;
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCourse.BackColor = System.Drawing.Color.White;
            this.txtSearchCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCourse.Location = new System.Drawing.Point(675, 20);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(216, 23);
            this.txtSearchCourse.TabIndex = 4;
            // 
            // ttpGeneral
            // 
            this.ttpGeneral.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpGeneral.ToolTipTitle = "This Button is Used to...";
            // 
            // pnlBtnLinkOption
            // 
            this.pnlBtnLinkOption.BackColor = System.Drawing.Color.LightGray;
            this.pnlBtnLinkOption.Controls.Add(this.button7);
            this.pnlBtnLinkOption.Controls.Add(this.button6);
            this.pnlBtnLinkOption.Controls.Add(this.button1);
            this.pnlBtnLinkOption.Location = new System.Drawing.Point(455, 41);
            this.pnlBtnLinkOption.Name = "pnlBtnLinkOption";
            this.pnlBtnLinkOption.Size = new System.Drawing.Size(200, 141);
            this.pnlBtnLinkOption.TabIndex = 10;
            this.pnlBtnLinkOption.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 47);
            this.button7.TabIndex = 2;
            this.button7.Text = "Student(s)";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 47);
            this.button6.TabIndex = 1;
            this.button6.Text = "Professor(s)";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Program(s)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLinkCourse
            // 
            this.btnLinkCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnLinkCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkCourse.FlatAppearance.BorderSize = 0;
            this.btnLinkCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnLinkCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnLinkCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkCourse.Image")));
            this.btnLinkCourse.Location = new System.Drawing.Point(452, 12);
            this.btnLinkCourse.Name = "btnLinkCourse";
            this.btnLinkCourse.Size = new System.Drawing.Size(45, 40);
            this.btnLinkCourse.TabIndex = 9;
            this.ttpGeneral.SetToolTip(this.btnLinkCourse, "Link a Course To...");
            this.btnLinkCourse.UseVisualStyleBackColor = false;
            this.btnLinkCourse.MouseEnter += new System.EventHandler(this.btnLinkCourse_MouseEnter);
            // 
            // btnPrintCourse
            // 
            this.btnPrintCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnPrintCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintCourse.FlatAppearance.BorderSize = 0;
            this.btnPrintCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnPrintCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnPrintCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCourse.Image")));
            this.btnPrintCourse.Location = new System.Drawing.Point(401, 12);
            this.btnPrintCourse.Name = "btnPrintCourse";
            this.btnPrintCourse.Size = new System.Drawing.Size(45, 40);
            this.btnPrintCourse.TabIndex = 8;
            this.ttpGeneral.SetToolTip(this.btnPrintCourse, "Print a Report");
            this.btnPrintCourse.UseVisualStyleBackColor = false;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnRemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCourse.FlatAppearance.BorderSize = 0;
            this.btnRemoveCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnRemoveCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCourse.Image")));
            this.btnRemoveCourse.Location = new System.Drawing.Point(350, 12);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(45, 40);
            this.btnRemoveCourse.TabIndex = 7;
            this.ttpGeneral.SetToolTip(this.btnRemoveCourse, "Remove a Course");
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnEditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCourse.FlatAppearance.BorderSize = 0;
            this.btnEditCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnEditCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCourse.Image")));
            this.btnEditCourse.Location = new System.Drawing.Point(299, 12);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(45, 40);
            this.btnEditCourse.TabIndex = 6;
            this.ttpGeneral.SetToolTip(this.btnEditCourse, "Edit a Course");
            this.btnEditCourse.UseVisualStyleBackColor = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnAddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.Location = new System.Drawing.Point(248, 12);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(45, 40);
            this.btnAddCourse.TabIndex = 5;
            this.ttpGeneral.SetToolTip(this.btnAddCourse, "Add a Course");
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 571);
            this.Controls.Add(this.pnlBtnLinkOption);
            this.Controls.Add(this.btnLinkCourse);
            this.Controls.Add(this.btnPrintCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtSearchCourse);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses | Student Content Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Courses_Load);
            this.MouseEnter += new System.EventHandler(this.frmCourses_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagerDBDataSet)).EndInit();
            this.pnlBtnLinkOption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHelloMsgBackgroundColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCourses;
        private StudentManagerDBDataSet studentManagerDBDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private StudentManagerDBDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private CircleButton btnAddCourse;
        private CircleButton btnEditCourse;
        private CircleButton btnRemoveCourse;
        private CircleButton btnPrintCourse;
        private CircleButton btnLinkCourse;
        private System.Windows.Forms.ToolTip ttpGeneral;
        private System.Windows.Forms.Panel pnlBtnLinkOption;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}