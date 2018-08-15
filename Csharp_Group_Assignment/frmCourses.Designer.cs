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
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pnlNavButtons = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavProfessors = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnNavStudents = new System.Windows.Forms.Button();
            this.btnNavPrograms = new System.Windows.Forms.Button();
            this.pnlHelloMsgBackgroundColor = new System.Windows.Forms.Panel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsAllData = new Csharp_Group_Assignment.dtsAll();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.ttpGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.btnLinkCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnPrintCourseReport = new Csharp_Group_Assignment.CircleButton();
            this.btnRemoveCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnEditCourse = new Csharp_Group_Assignment.CircleButton();
            this.btnAddCourse = new Csharp_Group_Assignment.CircleButton();
            this.pnlBtnLinkOption = new System.Windows.Forms.Panel();
            this.btnLinkStudent = new System.Windows.Forms.Button();
            this.btnLinkProfessor = new System.Windows.Forms.Button();
            this.btnLinkProgram = new System.Windows.Forms.Button();
            this.coursesTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.CoursesTableAdapter();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.ProgramTableAdapter();
            this.courseProgramTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.CourseProgramTableAdapter();
            this.professorCourseTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.ProfessorCourseTableAdapter();
            this.studentCourseTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.StudentCourseTableAdapter();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlNavButtons.SuspendLayout();
            this.pnlHelloMsgBackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsAllData)).BeginInit();
            this.pnlBtnLinkOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
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
            this.pnlLeftMenu.Location = new System.Drawing.Point(-1, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(242, 574);
            this.pnlLeftMenu.TabIndex = 0;
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
            this.btnNavHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnNavHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.ForeColor = System.Drawing.Color.White;
            this.btnNavHome.Location = new System.Drawing.Point(0, 0);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(199, 49);
            this.btnNavHome.TabIndex = 3;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = false;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
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
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn});
            this.dgvCourses.DataSource = this.coursesBindingSource;
            this.dgvCourses.Location = new System.Drawing.Point(248, 58);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCourses.Size = new System.Drawing.Size(746, 501);
            this.dgvCourses.TabIndex = 1;
            this.dgvCourses.MouseEnter += new System.EventHandler(this.dgvCourses_MouseEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 21;
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
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "courseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course Code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseCodeDataGridViewTextBoxColumn.Width = 93;
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
            this.coursesBindingSource.DataSource = this.dtsAllData;
            // 
            // dtsAllData
            // 
            this.dtsAllData.DataSetName = "dtsAll";
            this.dtsAllData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchCourse.BackColor = System.Drawing.Color.White;
            this.txtSearchCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCourse.Location = new System.Drawing.Point(675, 20);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(216, 23);
            this.txtSearchCourse.TabIndex = 1;
            this.txtSearchCourse.TextChanged += new System.EventHandler(this.txtSearchCourse_TextChanged);
            // 
            // ttpGeneral
            // 
            this.ttpGeneral.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpGeneral.ToolTipTitle = "This Button is Used to...";
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
            // btnPrintCourseReport
            // 
            this.btnPrintCourseReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnPrintCourseReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintCourseReport.FlatAppearance.BorderSize = 0;
            this.btnPrintCourseReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnPrintCourseReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnPrintCourseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCourseReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCourseReport.Image")));
            this.btnPrintCourseReport.Location = new System.Drawing.Point(401, 12);
            this.btnPrintCourseReport.Name = "btnPrintCourseReport";
            this.btnPrintCourseReport.Size = new System.Drawing.Size(45, 40);
            this.btnPrintCourseReport.TabIndex = 8;
            this.ttpGeneral.SetToolTip(this.btnPrintCourseReport, "Print a Report");
            this.btnPrintCourseReport.UseVisualStyleBackColor = false;
            this.btnPrintCourseReport.Click += new System.EventHandler(this.btnPrintCourseReport_Click);
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
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
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
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
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
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // pnlBtnLinkOption
            // 
            this.pnlBtnLinkOption.BackColor = System.Drawing.Color.LightGray;
            this.pnlBtnLinkOption.Controls.Add(this.btnLinkStudent);
            this.pnlBtnLinkOption.Controls.Add(this.btnLinkProfessor);
            this.pnlBtnLinkOption.Controls.Add(this.btnLinkProgram);
            this.pnlBtnLinkOption.Location = new System.Drawing.Point(455, 41);
            this.pnlBtnLinkOption.Name = "pnlBtnLinkOption";
            this.pnlBtnLinkOption.Size = new System.Drawing.Size(200, 141);
            this.pnlBtnLinkOption.TabIndex = 10;
            this.pnlBtnLinkOption.Visible = false;
            // 
            // btnLinkStudent
            // 
            this.btnLinkStudent.BackColor = System.Drawing.Color.White;
            this.btnLinkStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkStudent.FlatAppearance.BorderSize = 0;
            this.btnLinkStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLinkStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLinkStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkStudent.Location = new System.Drawing.Point(0, 96);
            this.btnLinkStudent.Name = "btnLinkStudent";
            this.btnLinkStudent.Size = new System.Drawing.Size(200, 47);
            this.btnLinkStudent.TabIndex = 2;
            this.btnLinkStudent.Text = "Student(s)";
            this.btnLinkStudent.UseVisualStyleBackColor = false;
            this.btnLinkStudent.Click += new System.EventHandler(this.btnLinkStudent_Click);
            // 
            // btnLinkProfessor
            // 
            this.btnLinkProfessor.BackColor = System.Drawing.Color.White;
            this.btnLinkProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkProfessor.FlatAppearance.BorderSize = 0;
            this.btnLinkProfessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLinkProfessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLinkProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkProfessor.Location = new System.Drawing.Point(0, 48);
            this.btnLinkProfessor.Name = "btnLinkProfessor";
            this.btnLinkProfessor.Size = new System.Drawing.Size(200, 47);
            this.btnLinkProfessor.TabIndex = 1;
            this.btnLinkProfessor.Text = "Professor(s)";
            this.btnLinkProfessor.UseVisualStyleBackColor = false;
            this.btnLinkProfessor.Click += new System.EventHandler(this.btnLinkProfessor_Click);
            // 
            // btnLinkProgram
            // 
            this.btnLinkProgram.BackColor = System.Drawing.Color.White;
            this.btnLinkProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkProgram.FlatAppearance.BorderSize = 0;
            this.btnLinkProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLinkProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLinkProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkProgram.Location = new System.Drawing.Point(0, 0);
            this.btnLinkProgram.Name = "btnLinkProgram";
            this.btnLinkProgram.Size = new System.Drawing.Size(200, 47);
            this.btnLinkProgram.TabIndex = 0;
            this.btnLinkProgram.Text = "Program(s)";
            this.btnLinkProgram.UseVisualStyleBackColor = false;
            this.btnLinkProgram.Click += new System.EventHandler(this.btnLinkProgram_Click);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.dtsAllData;
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
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 571);
            this.Controls.Add(this.pnlBtnLinkOption);
            this.Controls.Add(this.btnLinkCourse);
            this.Controls.Add(this.btnPrintCourseReport);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtSearchCourse);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.pnlLeftMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses | Student Content Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCourses_FormClosed);
            this.Load += new System.EventHandler(this.Courses_Load);
            this.MouseEnter += new System.EventHandler(this.frmCourses_MouseEnter);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlNavButtons.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsAllData)).EndInit();
            this.pnlBtnLinkOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Panel pnlHelloMsgBackgroundColor;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel pnlNavButtons;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavProfessors;
        private System.Windows.Forms.Button btnNavStudents;
        private System.Windows.Forms.Button btnNavPrograms;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private CircleButton btnAddCourse;
        private CircleButton btnEditCourse;
        private CircleButton btnRemoveCourse;
        private CircleButton btnPrintCourseReport;
        private CircleButton btnLinkCourse;
        private System.Windows.Forms.ToolTip ttpGeneral;
        private System.Windows.Forms.Panel pnlBtnLinkOption;
        private System.Windows.Forms.Button btnLinkStudent;
        private System.Windows.Forms.Button btnLinkProfessor;
        private System.Windows.Forms.Button btnLinkProgram;
        internal System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        public dtsAll dtsAllData;
        public dtsAllTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private dtsAllTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private dtsAllTableAdapters.CourseProgramTableAdapter courseProgramTableAdapter;
        private dtsAllTableAdapters.ProfessorCourseTableAdapter professorCourseTableAdapter;
        private dtsAllTableAdapters.StudentCourseTableAdapter studentCourseTableAdapter;
    }
}