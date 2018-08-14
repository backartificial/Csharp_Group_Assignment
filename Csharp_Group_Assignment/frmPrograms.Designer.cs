namespace Csharp_Group_Assignment {
    partial class frmPrograms {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrograms));
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pnlNavButtons = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavProfessors = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnNavStudents = new System.Windows.Forms.Button();
            this.btnNavPrograms = new System.Windows.Forms.Button();
            this.pnlHelloMsgBackgroundColor = new System.Windows.Forms.Panel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsAllData = new Csharp_Group_Assignment.dtsAll();
            this.btnSearchProgram = new System.Windows.Forms.Button();
            this.txtSearchProgram = new System.Windows.Forms.TextBox();
            this.ttpGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.btnLinkProgram = new Csharp_Group_Assignment.CircleButton();
            this.btnPrintProgramReport = new Csharp_Group_Assignment.CircleButton();
            this.btnRemoveProgram = new Csharp_Group_Assignment.CircleButton();
            this.btnEditProgram = new Csharp_Group_Assignment.CircleButton();
            this.btnAddProgram = new Csharp_Group_Assignment.CircleButton();
            this.pnlBtnLinkOption = new System.Windows.Forms.Panel();
            this.btnLinkStudent = new System.Windows.Forms.Button();
            this.btnLinkCourse = new System.Windows.Forms.Button();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.CoursesTableAdapter();
            this.programTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.ProgramTableAdapter();
            this.courseProgramTableAdapter = new Csharp_Group_Assignment.dtsAllTableAdapters.CourseProgramTableAdapter();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlNavButtons.SuspendLayout();
            this.pnlHelloMsgBackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsAllData)).BeginInit();
            this.pnlBtnLinkOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
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
            this.pnlLeftMenu.Size = new System.Drawing.Size(242, 597);
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
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
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
            this.btnNavPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
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
            // dgvPrograms
            // 
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.AllowUserToDeleteRows = false;
            this.dgvPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrograms.AutoGenerateColumns = false;
            this.dgvPrograms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.coopDataGridViewTextBoxColumn,
            this.outcomeDataGridViewTextBoxColumn});
            this.dgvPrograms.DataSource = this.programBindingSource;
            this.dgvPrograms.Location = new System.Drawing.Point(248, 58);
            this.dgvPrograms.MultiSelect = false;
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.RowHeadersVisible = false;
            this.dgvPrograms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrograms.Size = new System.Drawing.Size(754, 524);
            this.dgvPrograms.TabIndex = 1;
            this.dgvPrograms.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPrograms_CellFormatting);
            this.dgvPrograms.MouseEnter += new System.EventHandler(this.dvgPrograms_MouseEnter);
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Program Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 102;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Width = 72;
            // 
            // coopDataGridViewTextBoxColumn
            // 
            this.coopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coopDataGridViewTextBoxColumn.DataPropertyName = "coop";
            this.coopDataGridViewTextBoxColumn.HeaderText = "Co-op";
            this.coopDataGridViewTextBoxColumn.Name = "coopDataGridViewTextBoxColumn";
            this.coopDataGridViewTextBoxColumn.ReadOnly = true;
            this.coopDataGridViewTextBoxColumn.Width = 60;
            // 
            // outcomeDataGridViewTextBoxColumn
            // 
            this.outcomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.outcomeDataGridViewTextBoxColumn.DataPropertyName = "outcome";
            this.outcomeDataGridViewTextBoxColumn.HeaderText = "Outcome";
            this.outcomeDataGridViewTextBoxColumn.Name = "outcomeDataGridViewTextBoxColumn";
            this.outcomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.dtsAllData;
            this.programBindingSource.CurrentChanged += new System.EventHandler(this.programBindingSource_CurrentChanged);
            // 
            // dtsAllData
            // 
            this.dtsAllData.DataSetName = "dtsAll";
            this.dtsAllData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearchProgram
            // 
            this.btnSearchProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnSearchProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProgram.FlatAppearance.BorderSize = 0;
            this.btnSearchProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnSearchProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnSearchProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProgram.ForeColor = System.Drawing.Color.White;
            this.btnSearchProgram.Location = new System.Drawing.Point(905, 16);
            this.btnSearchProgram.Name = "btnSearchProgram";
            this.btnSearchProgram.Size = new System.Drawing.Size(97, 31);
            this.btnSearchProgram.TabIndex = 3;
            this.btnSearchProgram.Text = "Search";
            this.btnSearchProgram.UseVisualStyleBackColor = false;
            this.btnSearchProgram.Click += new System.EventHandler(this.btnSearchProgram_Click);
            // 
            // txtSearchProgram
            // 
            this.txtSearchProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchProgram.BackColor = System.Drawing.Color.White;
            this.txtSearchProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProgram.Location = new System.Drawing.Point(683, 20);
            this.txtSearchProgram.Name = "txtSearchProgram";
            this.txtSearchProgram.Size = new System.Drawing.Size(216, 23);
            this.txtSearchProgram.TabIndex = 1;
            this.txtSearchProgram.TextChanged += new System.EventHandler(this.txtSearchProgram_TextChanged);
            // 
            // ttpGeneral
            // 
            this.ttpGeneral.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpGeneral.ToolTipTitle = "This Button is Used to...";
            // 
            // btnLinkProgram
            // 
            this.btnLinkProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnLinkProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkProgram.FlatAppearance.BorderSize = 0;
            this.btnLinkProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnLinkProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnLinkProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkProgram.Image")));
            this.btnLinkProgram.Location = new System.Drawing.Point(452, 12);
            this.btnLinkProgram.Name = "btnLinkProgram";
            this.btnLinkProgram.Size = new System.Drawing.Size(45, 40);
            this.btnLinkProgram.TabIndex = 9;
            this.ttpGeneral.SetToolTip(this.btnLinkProgram, "Link a Program To...");
            this.btnLinkProgram.UseVisualStyleBackColor = false;
            this.btnLinkProgram.MouseEnter += new System.EventHandler(this.btnLinkCourse_MouseEnter);
            // 
            // btnPrintProgramReport
            // 
            this.btnPrintProgramReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnPrintProgramReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintProgramReport.FlatAppearance.BorderSize = 0;
            this.btnPrintProgramReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnPrintProgramReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnPrintProgramReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintProgramReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintProgramReport.Image")));
            this.btnPrintProgramReport.Location = new System.Drawing.Point(401, 12);
            this.btnPrintProgramReport.Name = "btnPrintProgramReport";
            this.btnPrintProgramReport.Size = new System.Drawing.Size(45, 40);
            this.btnPrintProgramReport.TabIndex = 8;
            this.ttpGeneral.SetToolTip(this.btnPrintProgramReport, "Print a Report");
            this.btnPrintProgramReport.UseVisualStyleBackColor = false;
            this.btnPrintProgramReport.Click += new System.EventHandler(this.btnPrintProgramReport_Click);
            // 
            // btnRemoveProgram
            // 
            this.btnRemoveProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnRemoveProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProgram.FlatAppearance.BorderSize = 0;
            this.btnRemoveProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnRemoveProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnRemoveProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveProgram.Image")));
            this.btnRemoveProgram.Location = new System.Drawing.Point(350, 12);
            this.btnRemoveProgram.Name = "btnRemoveProgram";
            this.btnRemoveProgram.Size = new System.Drawing.Size(45, 40);
            this.btnRemoveProgram.TabIndex = 7;
            this.ttpGeneral.SetToolTip(this.btnRemoveProgram, "Remove a Program");
            this.btnRemoveProgram.UseVisualStyleBackColor = false;
            this.btnRemoveProgram.Click += new System.EventHandler(this.btnRemoveProgram_Click);
            // 
            // btnEditProgram
            // 
            this.btnEditProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnEditProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProgram.FlatAppearance.BorderSize = 0;
            this.btnEditProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnEditProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnEditProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProgram.Image")));
            this.btnEditProgram.Location = new System.Drawing.Point(299, 12);
            this.btnEditProgram.Name = "btnEditProgram";
            this.btnEditProgram.Size = new System.Drawing.Size(45, 40);
            this.btnEditProgram.TabIndex = 6;
            this.ttpGeneral.SetToolTip(this.btnEditProgram, "Edit a Program");
            this.btnEditProgram.UseVisualStyleBackColor = false;
            this.btnEditProgram.Click += new System.EventHandler(this.btnEditProgram_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnAddProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProgram.FlatAppearance.BorderSize = 0;
            this.btnAddProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnAddProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(109)))), ((int)(((byte)(186)))));
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProgram.Image")));
            this.btnAddProgram.Location = new System.Drawing.Point(248, 12);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(45, 40);
            this.btnAddProgram.TabIndex = 5;
            this.ttpGeneral.SetToolTip(this.btnAddProgram, "Add a Program");
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // pnlBtnLinkOption
            // 
            this.pnlBtnLinkOption.BackColor = System.Drawing.Color.LightGray;
            this.pnlBtnLinkOption.Controls.Add(this.btnLinkStudent);
            this.pnlBtnLinkOption.Controls.Add(this.btnLinkCourse);
            this.pnlBtnLinkOption.Location = new System.Drawing.Point(455, 41);
            this.pnlBtnLinkOption.Name = "pnlBtnLinkOption";
            this.pnlBtnLinkOption.Size = new System.Drawing.Size(197, 91);
            this.pnlBtnLinkOption.TabIndex = 10;
            this.pnlBtnLinkOption.Visible = false;
            this.pnlBtnLinkOption.MouseEnter += new System.EventHandler(this.btnLinkProgram_MouseEnter);
            // 
            // btnLinkStudent
            // 
            this.btnLinkStudent.BackColor = System.Drawing.Color.White;
            this.btnLinkStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkStudent.FlatAppearance.BorderSize = 0;
            this.btnLinkStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLinkStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLinkStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkStudent.Location = new System.Drawing.Point(0, 44);
            this.btnLinkStudent.Name = "btnLinkStudent";
            this.btnLinkStudent.Size = new System.Drawing.Size(200, 47);
            this.btnLinkStudent.TabIndex = 2;
            this.btnLinkStudent.Text = "Student(s)";
            this.btnLinkStudent.UseVisualStyleBackColor = false;
            this.btnLinkStudent.Click += new System.EventHandler(this.btnLinkStudent_Click);
            // 
            // btnLinkCourse
            // 
            this.btnLinkCourse.BackColor = System.Drawing.Color.White;
            this.btnLinkCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkCourse.FlatAppearance.BorderSize = 0;
            this.btnLinkCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLinkCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLinkCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkCourse.Location = new System.Drawing.Point(0, 0);
            this.btnLinkCourse.Name = "btnLinkCourse";
            this.btnLinkCourse.Size = new System.Drawing.Size(200, 47);
            this.btnLinkCourse.TabIndex = 0;
            this.btnLinkCourse.Text = "Course(s)";
            this.btnLinkCourse.UseVisualStyleBackColor = false;
            this.btnLinkCourse.Click += new System.EventHandler(this.btnLinkProgram_Click);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dtsAllData;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // courseProgramTableAdapter
            // 
            this.courseProgramTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 594);
            this.Controls.Add(this.pnlBtnLinkOption);
            this.Controls.Add(this.btnLinkProgram);
            this.Controls.Add(this.btnPrintProgramReport);
            this.Controls.Add(this.btnRemoveProgram);
            this.Controls.Add(this.btnEditProgram);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.txtSearchProgram);
            this.Controls.Add(this.btnSearchProgram);
            this.Controls.Add(this.dgvPrograms);
            this.Controls.Add(this.pnlLeftMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs | Student Content Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Programs_Load);
            this.MouseEnter += new System.EventHandler(this.frmPrograms_MouseEnter);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlNavButtons.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.ResumeLayout(false);
            this.pnlHelloMsgBackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsAllData)).EndInit();
            this.pnlBtnLinkOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnSearchProgram;
        private System.Windows.Forms.TextBox txtSearchProgram;
        private CircleButton btnAddProgram;
        private CircleButton btnEditProgram;
        private CircleButton btnRemoveProgram;
        private CircleButton btnPrintProgramReport;
        private CircleButton btnLinkProgram;
        private System.Windows.Forms.ToolTip ttpGeneral;
        private System.Windows.Forms.Panel pnlBtnLinkOption;
        private System.Windows.Forms.Button btnLinkStudent;
        private System.Windows.Forms.Button btnLinkCourse;
        internal System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        public dtsAll dtsAllData;
        public dtsAllTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private dtsAllTableAdapters.CourseProgramTableAdapter courseProgramTableAdapter;
        public dtsAllTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcomeDataGridViewTextBoxColumn;
    }
}