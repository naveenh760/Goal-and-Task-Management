namespace GoalTask.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabGoals = new System.Windows.Forms.TabPage();
            this.cmBGoalStatus = new System.Windows.Forms.ComboBox();
            this.labelGoalStatus = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.btnCancelGoalAdd = new System.Windows.Forms.Button();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.cmBCategory = new System.Windows.Forms.ComboBox();
            this.dTPDeadline = new System.Windows.Forms.DateTimePicker();
            this.tBGoalDescription = new System.Windows.Forms.TextBox();
            this.tBGoalName = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelGoalDescription = new System.Windows.Forms.Label();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.btnCancelAddTask = new System.Windows.Forms.Button();
            this.cmBSelectGoal = new System.Windows.Forms.ComboBox();
            this.labelSelectGoal = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.cmBPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.cmBTaskStatus = new System.Windows.Forms.ComboBox();
            this.labelTaskStatus = new System.Windows.Forms.Label();
            this.labelTaskDeadline = new System.Windows.Forms.Label();
            this.dTPTaskDeadline = new System.Windows.Forms.DateTimePicker();
            this.tBTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.tBTaskName = new System.Windows.Forms.TextBox();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.tabViewGoals = new System.Windows.Forms.TabPage();
            this.labelFilterGoals = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDeadlineFilter = new System.Windows.Forms.Label();
            this.labelGStatusFilter = new System.Windows.Forms.Label();
            this.labelCategoryFilter = new System.Windows.Forms.Label();
            this.dTPDeadlineFilterTo = new System.Windows.Forms.DateTimePicker();
            this.dTPDeadlineFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.cmBGStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmBCategoryFilter = new System.Windows.Forms.ComboBox();
            this.dataGridViewGoals = new System.Windows.Forms.DataGridView();
            this.gBUpdateGoal = new System.Windows.Forms.GroupBox();
            this.labelModifyGoals = new System.Windows.Forms.Label();
            this.btnDeleteGoal = new System.Windows.Forms.Button();
            this.tBGoalNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateGoal = new System.Windows.Forms.Button();
            this.labelGoalNameUpdate = new System.Windows.Forms.Label();
            this.tBGoalDescriptionUpdate = new System.Windows.Forms.TextBox();
            this.cmBCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.labelGoalDescriptionUpdate = new System.Windows.Forms.Label();
            this.labelGStatusUpdate = new System.Windows.Forms.Label();
            this.cmBGStatusUpdate = new System.Windows.Forms.ComboBox();
            this.labelCategoryUpdate = new System.Windows.Forms.Label();
            this.tabViewTasks = new System.Windows.Forms.TabPage();
            this.labelFilterTasks = new System.Windows.Forms.Label();
            this.btnRefreshTask = new System.Windows.Forms.Button();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.labelToTask = new System.Windows.Forms.Label();
            this.labelTaskDeadlineFilter = new System.Windows.Forms.Label();
            this.labelTaskStatusFilter = new System.Windows.Forms.Label();
            this.labelGoalForTaskFilter = new System.Windows.Forms.Label();
            this.dTPTaskDeadlineTo = new System.Windows.Forms.DateTimePicker();
            this.dTPTaskDeadlineFrom = new System.Windows.Forms.DateTimePicker();
            this.cmBTaskStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmBGoalForTaskFilter = new System.Windows.Forms.ComboBox();
            this.gBUpdateTask = new System.Windows.Forms.GroupBox();
            this.labelModifyTasks = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnCloseTask = new System.Windows.Forms.Button();
            this.labeTaskNameUpdate = new System.Windows.Forms.Label();
            this.tBTaskNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.labelTaskStatusUpdate = new System.Windows.Forms.Label();
            this.tBTaskDescriptionUpdate = new System.Windows.Forms.TextBox();
            this.cmBPriorityUpdate = new System.Windows.Forms.ComboBox();
            this.labelTaskDescriptionUpdate = new System.Windows.Forms.Label();
            this.cmBTaskStatusUpdate = new System.Windows.Forms.ComboBox();
            this.labelPriorityUpdate = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlMain.SuspendLayout();
            this.tabGoals.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.tabViewGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).BeginInit();
            this.gBUpdateGoal.SuspendLayout();
            this.tabViewTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.gBUpdateTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabGoals);
            this.tabControlMain.Controls.Add(this.tabTasks);
            this.tabControlMain.Controls.Add(this.tabViewGoals);
            this.tabControlMain.Controls.Add(this.tabViewTasks);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1824, 786);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabGoals
            // 
            this.tabGoals.AutoScroll = true;
            this.tabGoals.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.tabGoals.AutoScrollMinSize = new System.Drawing.Size(3, 3);
            this.tabGoals.BackColor = System.Drawing.Color.LightBlue;
            this.tabGoals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabGoals.Controls.Add(this.cmBGoalStatus);
            this.tabGoals.Controls.Add(this.labelGoalStatus);
            this.tabGoals.Controls.Add(this.labelGoalName);
            this.tabGoals.Controls.Add(this.btnCancelGoalAdd);
            this.tabGoals.Controls.Add(this.btnAddGoal);
            this.tabGoals.Controls.Add(this.cmBCategory);
            this.tabGoals.Controls.Add(this.dTPDeadline);
            this.tabGoals.Controls.Add(this.tBGoalDescription);
            this.tabGoals.Controls.Add(this.tBGoalName);
            this.tabGoals.Controls.Add(this.labelCategory);
            this.tabGoals.Controls.Add(this.labelDeadline);
            this.tabGoals.Controls.Add(this.labelGoalDescription);
            this.tabGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGoals.Location = new System.Drawing.Point(4, 33);
            this.tabGoals.Name = "tabGoals";
            this.tabGoals.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoals.Size = new System.Drawing.Size(1816, 749);
            this.tabGoals.TabIndex = 0;
            this.tabGoals.Text = "Goals";
            // 
            // cmBGoalStatus
            // 
            this.cmBGoalStatus.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmBGoalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBGoalStatus.FormattingEnabled = true;
            this.cmBGoalStatus.Location = new System.Drawing.Point(975, 191);
            this.cmBGoalStatus.Name = "cmBGoalStatus";
            this.cmBGoalStatus.Size = new System.Drawing.Size(196, 33);
            this.cmBGoalStatus.TabIndex = 8;
            this.cmBGoalStatus.Click += new System.EventHandler(this.cmBGoalStatus_Click);
            // 
            // labelGoalStatus
            // 
            this.labelGoalStatus.AutoSize = true;
            this.labelGoalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalStatus.Location = new System.Drawing.Point(715, 199);
            this.labelGoalStatus.Name = "labelGoalStatus";
            this.labelGoalStatus.Size = new System.Drawing.Size(114, 25);
            this.labelGoalStatus.TabIndex = 4;
            this.labelGoalStatus.Text = "Goal Status";
            // 
            // labelGoalName
            // 
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.Location = new System.Drawing.Point(31, 94);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(144, 25);
            this.labelGoalName.TabIndex = 0;
            this.labelGoalName.Text = "Name of Goal *";
            // 
            // btnCancelGoalAdd
            // 
            this.btnCancelGoalAdd.AutoSize = true;
            this.btnCancelGoalAdd.CausesValidation = false;
            this.btnCancelGoalAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelGoalAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGoalAdd.Location = new System.Drawing.Point(739, 543);
            this.btnCancelGoalAdd.Name = "btnCancelGoalAdd";
            this.btnCancelGoalAdd.Size = new System.Drawing.Size(132, 41);
            this.btnCancelGoalAdd.TabIndex = 11;
            this.btnCancelGoalAdd.Text = "Cancel";
            this.btnCancelGoalAdd.UseVisualStyleBackColor = true;
            this.btnCancelGoalAdd.Click += new System.EventHandler(this.btnCancelGoalAdd_Click);
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.AutoSize = true;
            this.btnAddGoal.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGoal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoal.Location = new System.Drawing.Point(420, 543);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(132, 41);
            this.btnAddGoal.TabIndex = 10;
            this.btnAddGoal.Text = "Add Goal";
            this.btnAddGoal.UseVisualStyleBackColor = false;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // cmBCategory
            // 
            this.cmBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBCategory.FormattingEnabled = true;
            this.cmBCategory.Location = new System.Drawing.Point(975, 335);
            this.cmBCategory.Name = "cmBCategory";
            this.cmBCategory.Size = new System.Drawing.Size(196, 33);
            this.cmBCategory.TabIndex = 9;
            this.cmBCategory.Click += new System.EventHandler(this.cmBCategory_Click);
            // 
            // dTPDeadline
            // 
            this.dTPDeadline.CustomFormat = "dd/MM/yyyy";
            this.dTPDeadline.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTPDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDeadline.Location = new System.Drawing.Point(975, 58);
            this.dTPDeadline.Name = "dTPDeadline";
            this.dTPDeadline.Size = new System.Drawing.Size(196, 30);
            this.dTPDeadline.TabIndex = 7;
            // 
            // tBGoalDescription
            // 
            this.tBGoalDescription.Location = new System.Drawing.Point(264, 265);
            this.tBGoalDescription.Multiline = true;
            this.tBGoalDescription.Name = "tBGoalDescription";
            this.tBGoalDescription.Size = new System.Drawing.Size(347, 173);
            this.tBGoalDescription.TabIndex = 6;
            // 
            // tBGoalName
            // 
            this.tBGoalName.Location = new System.Drawing.Point(264, 58);
            this.tBGoalName.Multiline = true;
            this.tBGoalName.Name = "tBGoalName";
            this.tBGoalName.Size = new System.Drawing.Size(347, 85);
            this.tBGoalName.TabIndex = 5;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(715, 338);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(159, 25);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category of Goal";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeadline.Location = new System.Drawing.Point(715, 73);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(135, 25);
            this.labelDeadline.TabIndex = 2;
            this.labelDeadline.Text = "Goal Deadline";
            // 
            // labelGoalDescription
            // 
            this.labelGoalDescription.AutoSize = true;
            this.labelGoalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalDescription.Location = new System.Drawing.Point(31, 283);
            this.labelGoalDescription.Name = "labelGoalDescription";
            this.labelGoalDescription.Size = new System.Drawing.Size(109, 25);
            this.labelGoalDescription.TabIndex = 1;
            this.labelGoalDescription.Text = "Description";
            // 
            // tabTasks
            // 
            this.tabTasks.AutoScroll = true;
            this.tabTasks.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabTasks.BackColor = System.Drawing.Color.LightBlue;
            this.tabTasks.Controls.Add(this.btnCancelAddTask);
            this.tabTasks.Controls.Add(this.cmBSelectGoal);
            this.tabTasks.Controls.Add(this.labelSelectGoal);
            this.tabTasks.Controls.Add(this.btnAddTask);
            this.tabTasks.Controls.Add(this.cmBPriority);
            this.tabTasks.Controls.Add(this.labelPriority);
            this.tabTasks.Controls.Add(this.cmBTaskStatus);
            this.tabTasks.Controls.Add(this.labelTaskStatus);
            this.tabTasks.Controls.Add(this.labelTaskDeadline);
            this.tabTasks.Controls.Add(this.dTPTaskDeadline);
            this.tabTasks.Controls.Add(this.tBTaskDescription);
            this.tabTasks.Controls.Add(this.labelTaskDescription);
            this.tabTasks.Controls.Add(this.tBTaskName);
            this.tabTasks.Controls.Add(this.labelTaskName);
            this.tabTasks.Location = new System.Drawing.Point(4, 33);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(1816, 749);
            this.tabTasks.TabIndex = 1;
            this.tabTasks.Text = "Tasks";
            // 
            // btnCancelAddTask
            // 
            this.btnCancelAddTask.AutoSize = true;
            this.btnCancelAddTask.CausesValidation = false;
            this.btnCancelAddTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddTask.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddTask.Location = new System.Drawing.Point(718, 634);
            this.btnCancelAddTask.Name = "btnCancelAddTask";
            this.btnCancelAddTask.Size = new System.Drawing.Size(138, 41);
            this.btnCancelAddTask.TabIndex = 17;
            this.btnCancelAddTask.Text = "Cancel";
            this.btnCancelAddTask.UseVisualStyleBackColor = true;
            this.btnCancelAddTask.Click += new System.EventHandler(this.btnCancelAddTask_Click);
            // 
            // cmBSelectGoal
            // 
            this.cmBSelectGoal.FormattingEnabled = true;
            this.cmBSelectGoal.Location = new System.Drawing.Point(245, 480);
            this.cmBSelectGoal.Name = "cmBSelectGoal";
            this.cmBSelectGoal.Size = new System.Drawing.Size(347, 32);
            this.cmBSelectGoal.TabIndex = 16;
            this.cmBSelectGoal.Click += new System.EventHandler(this.cmBSelectGoal_Click);
            // 
            // labelSelectGoal
            // 
            this.labelSelectGoal.AutoSize = true;
            this.labelSelectGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGoal.Location = new System.Drawing.Point(42, 480);
            this.labelSelectGoal.Name = "labelSelectGoal";
            this.labelSelectGoal.Size = new System.Drawing.Size(118, 25);
            this.labelSelectGoal.TabIndex = 15;
            this.labelSelectGoal.Text = "Select Goal ";
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoSize = true;
            this.btnAddTask.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(436, 634);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(131, 41);
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // cmBPriority
            // 
            this.cmBPriority.FormattingEnabled = true;
            this.cmBPriority.Location = new System.Drawing.Point(875, 366);
            this.cmBPriority.Name = "cmBPriority";
            this.cmBPriority.Size = new System.Drawing.Size(200, 32);
            this.cmBPriority.TabIndex = 13;
            this.cmBPriority.Click += new System.EventHandler(this.cmBPriority_Click);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriority.Location = new System.Drawing.Point(676, 369);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(71, 25);
            this.labelPriority.TabIndex = 12;
            this.labelPriority.Text = "Priority";
            // 
            // cmBTaskStatus
            // 
            this.cmBTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBTaskStatus.FormattingEnabled = true;
            this.cmBTaskStatus.Location = new System.Drawing.Point(875, 228);
            this.cmBTaskStatus.Name = "cmBTaskStatus";
            this.cmBTaskStatus.Size = new System.Drawing.Size(195, 32);
            this.cmBTaskStatus.TabIndex = 11;
            this.cmBTaskStatus.Click += new System.EventHandler(this.cmBTaskStatus_Click);
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskStatus.Location = new System.Drawing.Point(676, 231);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(117, 25);
            this.labelTaskStatus.TabIndex = 10;
            this.labelTaskStatus.Text = "Task Status";
            // 
            // labelTaskDeadline
            // 
            this.labelTaskDeadline.AutoSize = true;
            this.labelTaskDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskDeadline.Location = new System.Drawing.Point(676, 67);
            this.labelTaskDeadline.Name = "labelTaskDeadline";
            this.labelTaskDeadline.Size = new System.Drawing.Size(138, 25);
            this.labelTaskDeadline.TabIndex = 3;
            this.labelTaskDeadline.Text = "Task Deadline";
            // 
            // dTPTaskDeadline
            // 
            this.dTPTaskDeadline.CustomFormat = "dd/MM/yyyy";
            this.dTPTaskDeadline.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTPTaskDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTaskDeadline.Location = new System.Drawing.Point(875, 67);
            this.dTPTaskDeadline.Name = "dTPTaskDeadline";
            this.dTPTaskDeadline.Size = new System.Drawing.Size(195, 32);
            this.dTPTaskDeadline.TabIndex = 9;
            // 
            // tBTaskDescription
            // 
            this.tBTaskDescription.Location = new System.Drawing.Point(245, 212);
            this.tBTaskDescription.Multiline = true;
            this.tBTaskDescription.Name = "tBTaskDescription";
            this.tBTaskDescription.Size = new System.Drawing.Size(347, 173);
            this.tBTaskDescription.TabIndex = 8;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskDescription.Location = new System.Drawing.Point(42, 253);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(109, 25);
            this.labelTaskDescription.TabIndex = 7;
            this.labelTaskDescription.Text = "Description";
            // 
            // tBTaskName
            // 
            this.tBTaskName.Location = new System.Drawing.Point(245, 56);
            this.tBTaskName.Multiline = true;
            this.tBTaskName.Name = "tBTaskName";
            this.tBTaskName.Size = new System.Drawing.Size(347, 69);
            this.tBTaskName.TabIndex = 6;
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskName.Location = new System.Drawing.Point(42, 56);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(147, 25);
            this.labelTaskName.TabIndex = 1;
            this.labelTaskName.Text = "Name of Task *";
            // 
            // tabViewGoals
            // 
            this.tabViewGoals.AutoScroll = true;
            this.tabViewGoals.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabViewGoals.BackColor = System.Drawing.Color.LightBlue;
            this.tabViewGoals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabViewGoals.Controls.Add(this.labelFilterGoals);
            this.tabViewGoals.Controls.Add(this.btnRefresh);
            this.tabViewGoals.Controls.Add(this.btnSearch);
            this.tabViewGoals.Controls.Add(this.labelDateTo);
            this.tabViewGoals.Controls.Add(this.labelDeadlineFilter);
            this.tabViewGoals.Controls.Add(this.labelGStatusFilter);
            this.tabViewGoals.Controls.Add(this.labelCategoryFilter);
            this.tabViewGoals.Controls.Add(this.dTPDeadlineFilterTo);
            this.tabViewGoals.Controls.Add(this.dTPDeadlineFilterFrom);
            this.tabViewGoals.Controls.Add(this.cmBGStatusFilter);
            this.tabViewGoals.Controls.Add(this.cmBCategoryFilter);
            this.tabViewGoals.Controls.Add(this.dataGridViewGoals);
            this.tabViewGoals.Controls.Add(this.gBUpdateGoal);
            this.tabViewGoals.Location = new System.Drawing.Point(4, 33);
            this.tabViewGoals.Name = "tabViewGoals";
            this.tabViewGoals.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewGoals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabViewGoals.Size = new System.Drawing.Size(1816, 749);
            this.tabViewGoals.TabIndex = 2;
            this.tabViewGoals.Text = "Goal DashBoard";
            this.tabViewGoals.ToolTipText = "hai";
            // 
            // labelFilterGoals
            // 
            this.labelFilterGoals.AutoSize = true;
            this.labelFilterGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterGoals.Location = new System.Drawing.Point(364, 15);
            this.labelFilterGoals.Name = "labelFilterGoals";
            this.labelFilterGoals.Size = new System.Drawing.Size(149, 29);
            this.labelFilterGoals.TabIndex = 22;
            this.labelFilterGoals.Text = "Filter Goals";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(481, 181);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 51);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(228, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 51);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(784, 84);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(33, 24);
            this.labelDateTo.TabIndex = 8;
            this.labelDateTo.Text = "To";
            // 
            // labelDeadlineFilter
            // 
            this.labelDeadlineFilter.AutoSize = true;
            this.labelDeadlineFilter.Location = new System.Drawing.Point(608, 74);
            this.labelDeadlineFilter.Name = "labelDeadlineFilter";
            this.labelDeadlineFilter.Size = new System.Drawing.Size(89, 24);
            this.labelDeadlineFilter.TabIndex = 7;
            this.labelDeadlineFilter.Text = "Deadline";
            // 
            // labelGStatusFilter
            // 
            this.labelGStatusFilter.AutoSize = true;
            this.labelGStatusFilter.Location = new System.Drawing.Point(274, 69);
            this.labelGStatusFilter.Name = "labelGStatusFilter";
            this.labelGStatusFilter.Size = new System.Drawing.Size(112, 24);
            this.labelGStatusFilter.TabIndex = 6;
            this.labelGStatusFilter.Text = "Goal Status";
            // 
            // labelCategoryFilter
            // 
            this.labelCategoryFilter.AutoSize = true;
            this.labelCategoryFilter.Location = new System.Drawing.Point(6, 69);
            this.labelCategoryFilter.Name = "labelCategoryFilter";
            this.labelCategoryFilter.Size = new System.Drawing.Size(90, 24);
            this.labelCategoryFilter.TabIndex = 5;
            this.labelCategoryFilter.Text = "Category";
            // 
            // dTPDeadlineFilterTo
            // 
            this.dTPDeadlineFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDeadlineFilterTo.Location = new System.Drawing.Point(703, 120);
            this.dTPDeadlineFilterTo.Name = "dTPDeadlineFilterTo";
            this.dTPDeadlineFilterTo.ShowCheckBox = true;
            this.dTPDeadlineFilterTo.Size = new System.Drawing.Size(200, 32);
            this.dTPDeadlineFilterTo.TabIndex = 4;
            this.dTPDeadlineFilterTo.Value = new System.DateTime(2017, 9, 30, 0, 0, 0, 0);
            // 
            // dTPDeadlineFilterFrom
            // 
            this.dTPDeadlineFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDeadlineFilterFrom.Location = new System.Drawing.Point(703, 40);
            this.dTPDeadlineFilterFrom.Name = "dTPDeadlineFilterFrom";
            this.dTPDeadlineFilterFrom.ShowCheckBox = true;
            this.dTPDeadlineFilterFrom.Size = new System.Drawing.Size(200, 32);
            this.dTPDeadlineFilterFrom.TabIndex = 3;
            this.dTPDeadlineFilterFrom.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            // 
            // cmBGStatusFilter
            // 
            this.cmBGStatusFilter.FormattingEnabled = true;
            this.cmBGStatusFilter.Location = new System.Drawing.Point(406, 66);
            this.cmBGStatusFilter.Name = "cmBGStatusFilter";
            this.cmBGStatusFilter.Size = new System.Drawing.Size(176, 32);
            this.cmBGStatusFilter.TabIndex = 2;
            this.cmBGStatusFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBGStatusFilter_MouseClick);
            // 
            // cmBCategoryFilter
            // 
            this.cmBCategoryFilter.FormattingEnabled = true;
            this.cmBCategoryFilter.Location = new System.Drawing.Point(109, 61);
            this.cmBCategoryFilter.Name = "cmBCategoryFilter";
            this.cmBCategoryFilter.Size = new System.Drawing.Size(127, 32);
            this.cmBCategoryFilter.TabIndex = 1;
            this.cmBCategoryFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBCategoryFilter_MouseClick);
            // 
            // dataGridViewGoals
            // 
            this.dataGridViewGoals.AllowUserToAddRows = false;
            this.dataGridViewGoals.AllowUserToDeleteRows = false;
            this.dataGridViewGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGoals.Location = new System.Drawing.Point(6, 353);
            this.dataGridViewGoals.MultiSelect = false;
            this.dataGridViewGoals.Name = "dataGridViewGoals";
            this.dataGridViewGoals.ReadOnly = true;
            this.dataGridViewGoals.RowTemplate.Height = 28;
            this.dataGridViewGoals.Size = new System.Drawing.Size(942, 461);
            this.dataGridViewGoals.TabIndex = 0;
            this.dataGridViewGoals.Visible = false;
            this.dataGridViewGoals.SelectionChanged += new System.EventHandler(this.dataGridViewGoals_SelectionChanged);
            // 
            // gBUpdateGoal
            // 
            this.gBUpdateGoal.AutoSize = true;
            this.gBUpdateGoal.Controls.Add(this.labelModifyGoals);
            this.gBUpdateGoal.Controls.Add(this.btnDeleteGoal);
            this.gBUpdateGoal.Controls.Add(this.tBGoalNameUpdate);
            this.gBUpdateGoal.Controls.Add(this.btnUpdateGoal);
            this.gBUpdateGoal.Controls.Add(this.labelGoalNameUpdate);
            this.gBUpdateGoal.Controls.Add(this.tBGoalDescriptionUpdate);
            this.gBUpdateGoal.Controls.Add(this.cmBCategoryUpdate);
            this.gBUpdateGoal.Controls.Add(this.labelGoalDescriptionUpdate);
            this.gBUpdateGoal.Controls.Add(this.labelGStatusUpdate);
            this.gBUpdateGoal.Controls.Add(this.cmBGStatusUpdate);
            this.gBUpdateGoal.Controls.Add(this.labelCategoryUpdate);
            this.gBUpdateGoal.Location = new System.Drawing.Point(988, 40);
            this.gBUpdateGoal.Name = "gBUpdateGoal";
            this.gBUpdateGoal.Size = new System.Drawing.Size(772, 729);
            this.gBUpdateGoal.TabIndex = 21;
            this.gBUpdateGoal.TabStop = false;
            this.gBUpdateGoal.Visible = false;
            // 
            // labelModifyGoals
            // 
            this.labelModifyGoals.AutoSize = true;
            this.labelModifyGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifyGoals.Location = new System.Drawing.Point(350, 21);
            this.labelModifyGoals.Name = "labelModifyGoals";
            this.labelModifyGoals.Size = new System.Drawing.Size(165, 29);
            this.labelModifyGoals.TabIndex = 23;
            this.labelModifyGoals.Text = "Modify Goals";
            // 
            // btnDeleteGoal
            // 
            this.btnDeleteGoal.Location = new System.Drawing.Point(458, 579);
            this.btnDeleteGoal.Name = "btnDeleteGoal";
            this.btnDeleteGoal.Size = new System.Drawing.Size(125, 40);
            this.btnDeleteGoal.TabIndex = 20;
            this.btnDeleteGoal.Text = "Delete";
            this.btnDeleteGoal.UseVisualStyleBackColor = true;
            this.btnDeleteGoal.Click += new System.EventHandler(this.btnDeleteGoal_Click);
            // 
            // tBGoalNameUpdate
            // 
            this.tBGoalNameUpdate.Location = new System.Drawing.Point(41, 132);
            this.tBGoalNameUpdate.Multiline = true;
            this.tBGoalNameUpdate.Name = "tBGoalNameUpdate";
            this.tBGoalNameUpdate.Size = new System.Drawing.Size(309, 69);
            this.tBGoalNameUpdate.TabIndex = 15;
            // 
            // btnUpdateGoal
            // 
            this.btnUpdateGoal.Location = new System.Drawing.Point(86, 579);
            this.btnUpdateGoal.Name = "btnUpdateGoal";
            this.btnUpdateGoal.Size = new System.Drawing.Size(117, 40);
            this.btnUpdateGoal.TabIndex = 19;
            this.btnUpdateGoal.Text = "Update";
            this.btnUpdateGoal.UseVisualStyleBackColor = true;
            this.btnUpdateGoal.Click += new System.EventHandler(this.btnUpdateGoal_Click);
            // 
            // labelGoalNameUpdate
            // 
            this.labelGoalNameUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGoalNameUpdate.AutoSize = true;
            this.labelGoalNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalNameUpdate.Location = new System.Drawing.Point(36, 59);
            this.labelGoalNameUpdate.Name = "labelGoalNameUpdate";
            this.labelGoalNameUpdate.Size = new System.Drawing.Size(136, 25);
            this.labelGoalNameUpdate.TabIndex = 11;
            this.labelGoalNameUpdate.Text = "Name of Goal ";
            // 
            // tBGoalDescriptionUpdate
            // 
            this.tBGoalDescriptionUpdate.Location = new System.Drawing.Point(28, 313);
            this.tBGoalDescriptionUpdate.Multiline = true;
            this.tBGoalDescriptionUpdate.Name = "tBGoalDescriptionUpdate";
            this.tBGoalDescriptionUpdate.Size = new System.Drawing.Size(735, 203);
            this.tBGoalDescriptionUpdate.TabIndex = 16;
            // 
            // cmBCategoryUpdate
            // 
            this.cmBCategoryUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBCategoryUpdate.FormattingEnabled = true;
            this.cmBCategoryUpdate.Location = new System.Drawing.Point(546, 254);
            this.cmBCategoryUpdate.Name = "cmBCategoryUpdate";
            this.cmBCategoryUpdate.Size = new System.Drawing.Size(179, 32);
            this.cmBCategoryUpdate.TabIndex = 18;
            // 
            // labelGoalDescriptionUpdate
            // 
            this.labelGoalDescriptionUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGoalDescriptionUpdate.AutoSize = true;
            this.labelGoalDescriptionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalDescriptionUpdate.Location = new System.Drawing.Point(36, 254);
            this.labelGoalDescriptionUpdate.Name = "labelGoalDescriptionUpdate";
            this.labelGoalDescriptionUpdate.Size = new System.Drawing.Size(109, 25);
            this.labelGoalDescriptionUpdate.TabIndex = 12;
            this.labelGoalDescriptionUpdate.Text = "Description";
            // 
            // labelGStatusUpdate
            // 
            this.labelGStatusUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGStatusUpdate.AutoSize = true;
            this.labelGStatusUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGStatusUpdate.Location = new System.Drawing.Point(577, 59);
            this.labelGStatusUpdate.Name = "labelGStatusUpdate";
            this.labelGStatusUpdate.Size = new System.Drawing.Size(114, 25);
            this.labelGStatusUpdate.TabIndex = 14;
            this.labelGStatusUpdate.Text = "Goal Status";
            // 
            // cmBGStatusUpdate
            // 
            this.cmBGStatusUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBGStatusUpdate.FormattingEnabled = true;
            this.cmBGStatusUpdate.Location = new System.Drawing.Point(541, 118);
            this.cmBGStatusUpdate.Name = "cmBGStatusUpdate";
            this.cmBGStatusUpdate.Size = new System.Drawing.Size(184, 32);
            this.cmBGStatusUpdate.TabIndex = 17;
            // 
            // labelCategoryUpdate
            // 
            this.labelCategoryUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoryUpdate.AutoSize = true;
            this.labelCategoryUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryUpdate.Location = new System.Drawing.Point(556, 209);
            this.labelCategoryUpdate.Name = "labelCategoryUpdate";
            this.labelCategoryUpdate.Size = new System.Drawing.Size(159, 25);
            this.labelCategoryUpdate.TabIndex = 13;
            this.labelCategoryUpdate.Text = "Category of Goal";
            // 
            // tabViewTasks
            // 
            this.tabViewTasks.AutoScroll = true;
            this.tabViewTasks.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabViewTasks.BackColor = System.Drawing.Color.LightBlue;
            this.tabViewTasks.Controls.Add(this.labelFilterTasks);
            this.tabViewTasks.Controls.Add(this.btnRefreshTask);
            this.tabViewTasks.Controls.Add(this.btnSearchTask);
            this.tabViewTasks.Controls.Add(this.dataGridViewTasks);
            this.tabViewTasks.Controls.Add(this.labelToTask);
            this.tabViewTasks.Controls.Add(this.labelTaskDeadlineFilter);
            this.tabViewTasks.Controls.Add(this.labelTaskStatusFilter);
            this.tabViewTasks.Controls.Add(this.labelGoalForTaskFilter);
            this.tabViewTasks.Controls.Add(this.dTPTaskDeadlineTo);
            this.tabViewTasks.Controls.Add(this.dTPTaskDeadlineFrom);
            this.tabViewTasks.Controls.Add(this.cmBTaskStatusFilter);
            this.tabViewTasks.Controls.Add(this.cmBGoalForTaskFilter);
            this.tabViewTasks.Controls.Add(this.gBUpdateTask);
            this.tabViewTasks.Location = new System.Drawing.Point(4, 33);
            this.tabViewTasks.Name = "tabViewTasks";
            this.tabViewTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewTasks.Size = new System.Drawing.Size(1816, 749);
            this.tabViewTasks.TabIndex = 3;
            this.tabViewTasks.Text = "Task Dashboard";
            // 
            // labelFilterTasks
            // 
            this.labelFilterTasks.AutoSize = true;
            this.labelFilterTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterTasks.Location = new System.Drawing.Point(299, 22);
            this.labelFilterTasks.Name = "labelFilterTasks";
            this.labelFilterTasks.Size = new System.Drawing.Size(151, 29);
            this.labelFilterTasks.TabIndex = 33;
            this.labelFilterTasks.Text = "Filter Tasks";
            // 
            // btnRefreshTask
            // 
            this.btnRefreshTask.AutoSize = true;
            this.btnRefreshTask.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTask.Location = new System.Drawing.Point(470, 191);
            this.btnRefreshTask.Name = "btnRefreshTask";
            this.btnRefreshTask.Size = new System.Drawing.Size(135, 42);
            this.btnRefreshTask.TabIndex = 19;
            this.btnRefreshTask.Text = "Refresh";
            this.btnRefreshTask.UseVisualStyleBackColor = true;
            this.btnRefreshTask.Click += new System.EventHandler(this.btnRefreshTask_Click);
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.AutoSize = true;
            this.btnSearchTask.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTask.Location = new System.Drawing.Point(163, 191);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(134, 42);
            this.btnSearchTask.TabIndex = 18;
            this.btnSearchTask.Text = "Search";
            this.btnSearchTask.UseVisualStyleBackColor = true;
            this.btnSearchTask.Click += new System.EventHandler(this.btnSearchTask_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(6, 330);
            this.dataGridViewTasks.MultiSelect = false;
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.RowTemplate.Height = 28;
            this.dataGridViewTasks.Size = new System.Drawing.Size(972, 416);
            this.dataGridViewTasks.TabIndex = 17;
            this.dataGridViewTasks.Visible = false;
            this.dataGridViewTasks.SelectionChanged += new System.EventHandler(this.dataGridViewTasks_SelectionChanged);
            // 
            // labelToTask
            // 
            this.labelToTask.AutoSize = true;
            this.labelToTask.Location = new System.Drawing.Point(831, 81);
            this.labelToTask.Name = "labelToTask";
            this.labelToTask.Size = new System.Drawing.Size(33, 24);
            this.labelToTask.TabIndex = 16;
            this.labelToTask.Text = "To";
            // 
            // labelTaskDeadlineFilter
            // 
            this.labelTaskDeadlineFilter.AutoSize = true;
            this.labelTaskDeadlineFilter.Location = new System.Drawing.Point(653, 81);
            this.labelTaskDeadlineFilter.Name = "labelTaskDeadlineFilter";
            this.labelTaskDeadlineFilter.Size = new System.Drawing.Size(89, 24);
            this.labelTaskDeadlineFilter.TabIndex = 15;
            this.labelTaskDeadlineFilter.Text = "Deadline";
            // 
            // labelTaskStatusFilter
            // 
            this.labelTaskStatusFilter.AutoSize = true;
            this.labelTaskStatusFilter.Location = new System.Drawing.Point(384, 76);
            this.labelTaskStatusFilter.Name = "labelTaskStatusFilter";
            this.labelTaskStatusFilter.Size = new System.Drawing.Size(66, 24);
            this.labelTaskStatusFilter.TabIndex = 14;
            this.labelTaskStatusFilter.Text = "Status";
            this.labelTaskStatusFilter.Click += new System.EventHandler(this.labelTaskStatusFilter_Click);
            // 
            // labelGoalForTaskFilter
            // 
            this.labelGoalForTaskFilter.AutoSize = true;
            this.labelGoalForTaskFilter.Location = new System.Drawing.Point(17, 73);
            this.labelGoalForTaskFilter.Name = "labelGoalForTaskFilter";
            this.labelGoalForTaskFilter.Size = new System.Drawing.Size(50, 24);
            this.labelGoalForTaskFilter.TabIndex = 13;
            this.labelGoalForTaskFilter.Text = "Goal";
            // 
            // dTPTaskDeadlineTo
            // 
            this.dTPTaskDeadlineTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTaskDeadlineTo.Location = new System.Drawing.Point(741, 134);
            this.dTPTaskDeadlineTo.Name = "dTPTaskDeadlineTo";
            this.dTPTaskDeadlineTo.ShowCheckBox = true;
            this.dTPTaskDeadlineTo.Size = new System.Drawing.Size(200, 32);
            this.dTPTaskDeadlineTo.TabIndex = 12;
            this.dTPTaskDeadlineTo.Value = new System.DateTime(2017, 9, 30, 0, 0, 0, 0);
            // 
            // dTPTaskDeadlineFrom
            // 
            this.dTPTaskDeadlineFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTaskDeadlineFrom.Location = new System.Drawing.Point(741, 25);
            this.dTPTaskDeadlineFrom.Name = "dTPTaskDeadlineFrom";
            this.dTPTaskDeadlineFrom.ShowCheckBox = true;
            this.dTPTaskDeadlineFrom.Size = new System.Drawing.Size(200, 32);
            this.dTPTaskDeadlineFrom.TabIndex = 11;
            this.dTPTaskDeadlineFrom.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            // 
            // cmBTaskStatusFilter
            // 
            this.cmBTaskStatusFilter.FormattingEnabled = true;
            this.cmBTaskStatusFilter.Location = new System.Drawing.Point(470, 70);
            this.cmBTaskStatusFilter.Name = "cmBTaskStatusFilter";
            this.cmBTaskStatusFilter.Size = new System.Drawing.Size(141, 32);
            this.cmBTaskStatusFilter.TabIndex = 10;
            this.cmBTaskStatusFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBTaskStatusFilter_MouseClick);
            // 
            // cmBGoalForTaskFilter
            // 
            this.cmBGoalForTaskFilter.FormattingEnabled = true;
            this.cmBGoalForTaskFilter.Location = new System.Drawing.Point(96, 71);
            this.cmBGoalForTaskFilter.Name = "cmBGoalForTaskFilter";
            this.cmBGoalForTaskFilter.Size = new System.Drawing.Size(254, 32);
            this.cmBGoalForTaskFilter.TabIndex = 9;
            this.cmBGoalForTaskFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBGoalForTaskFilter_MouseClick);
            // 
            // gBUpdateTask
            // 
            this.gBUpdateTask.AutoSize = true;
            this.gBUpdateTask.Controls.Add(this.labelModifyTasks);
            this.gBUpdateTask.Controls.Add(this.btnDeleteTask);
            this.gBUpdateTask.Controls.Add(this.btnCloseTask);
            this.gBUpdateTask.Controls.Add(this.labeTaskNameUpdate);
            this.gBUpdateTask.Controls.Add(this.tBTaskNameUpdate);
            this.gBUpdateTask.Controls.Add(this.btnUpdateTask);
            this.gBUpdateTask.Controls.Add(this.labelTaskStatusUpdate);
            this.gBUpdateTask.Controls.Add(this.tBTaskDescriptionUpdate);
            this.gBUpdateTask.Controls.Add(this.cmBPriorityUpdate);
            this.gBUpdateTask.Controls.Add(this.labelTaskDescriptionUpdate);
            this.gBUpdateTask.Controls.Add(this.cmBTaskStatusUpdate);
            this.gBUpdateTask.Controls.Add(this.labelPriorityUpdate);
            this.gBUpdateTask.Location = new System.Drawing.Point(1015, 6);
            this.gBUpdateTask.Name = "gBUpdateTask";
            this.gBUpdateTask.Size = new System.Drawing.Size(728, 666);
            this.gBUpdateTask.TabIndex = 32;
            this.gBUpdateTask.TabStop = false;
            this.gBUpdateTask.Visible = false;
            // 
            // labelModifyTasks
            // 
            this.labelModifyTasks.AutoSize = true;
            this.labelModifyTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifyTasks.Location = new System.Drawing.Point(316, 0);
            this.labelModifyTasks.Name = "labelModifyTasks";
            this.labelModifyTasks.Size = new System.Drawing.Size(167, 29);
            this.labelModifyTasks.TabIndex = 34;
            this.labelModifyTasks.Text = "Modify Tasks";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(581, 553);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(131, 43);
            this.btnDeleteTask.TabIndex = 30;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnCloseTask
            // 
            this.btnCloseTask.Location = new System.Drawing.Point(321, 551);
            this.btnCloseTask.Name = "btnCloseTask";
            this.btnCloseTask.Size = new System.Drawing.Size(118, 43);
            this.btnCloseTask.TabIndex = 31;
            this.btnCloseTask.Text = "Close Task";
            this.btnCloseTask.UseVisualStyleBackColor = true;
            this.btnCloseTask.Click += new System.EventHandler(this.btnCloseTask_Click);
            // 
            // labeTaskNameUpdate
            // 
            this.labeTaskNameUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeTaskNameUpdate.AutoSize = true;
            this.labeTaskNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTaskNameUpdate.Location = new System.Drawing.Point(79, 28);
            this.labeTaskNameUpdate.Name = "labeTaskNameUpdate";
            this.labeTaskNameUpdate.Size = new System.Drawing.Size(134, 25);
            this.labeTaskNameUpdate.TabIndex = 21;
            this.labeTaskNameUpdate.Text = "Name of Task";
            // 
            // tBTaskNameUpdate
            // 
            this.tBTaskNameUpdate.Location = new System.Drawing.Point(21, 67);
            this.tBTaskNameUpdate.Multiline = true;
            this.tBTaskNameUpdate.Name = "tBTaskNameUpdate";
            this.tBTaskNameUpdate.Size = new System.Drawing.Size(309, 69);
            this.tBTaskNameUpdate.TabIndex = 25;
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(21, 554);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(127, 40);
            this.btnUpdateTask.TabIndex = 29;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // labelTaskStatusUpdate
            // 
            this.labelTaskStatusUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTaskStatusUpdate.AutoSize = true;
            this.labelTaskStatusUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskStatusUpdate.Location = new System.Drawing.Point(576, 28);
            this.labelTaskStatusUpdate.Name = "labelTaskStatusUpdate";
            this.labelTaskStatusUpdate.Size = new System.Drawing.Size(117, 25);
            this.labelTaskStatusUpdate.TabIndex = 24;
            this.labelTaskStatusUpdate.Text = "Task Status";
            // 
            // tBTaskDescriptionUpdate
            // 
            this.tBTaskDescriptionUpdate.Location = new System.Drawing.Point(1, 324);
            this.tBTaskDescriptionUpdate.Multiline = true;
            this.tBTaskDescriptionUpdate.Name = "tBTaskDescriptionUpdate";
            this.tBTaskDescriptionUpdate.Size = new System.Drawing.Size(721, 173);
            this.tBTaskDescriptionUpdate.TabIndex = 26;
            // 
            // cmBPriorityUpdate
            // 
            this.cmBPriorityUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBPriorityUpdate.FormattingEnabled = true;
            this.cmBPriorityUpdate.Location = new System.Drawing.Point(533, 221);
            this.cmBPriorityUpdate.Name = "cmBPriorityUpdate";
            this.cmBPriorityUpdate.Size = new System.Drawing.Size(179, 32);
            this.cmBPriorityUpdate.TabIndex = 28;
            this.cmBPriorityUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBPriorityUpdate_MouseClick);
            // 
            // labelTaskDescriptionUpdate
            // 
            this.labelTaskDescriptionUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTaskDescriptionUpdate.AutoSize = true;
            this.labelTaskDescriptionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskDescriptionUpdate.Location = new System.Drawing.Point(79, 253);
            this.labelTaskDescriptionUpdate.Name = "labelTaskDescriptionUpdate";
            this.labelTaskDescriptionUpdate.Size = new System.Drawing.Size(109, 25);
            this.labelTaskDescriptionUpdate.TabIndex = 22;
            this.labelTaskDescriptionUpdate.Text = "Description";
            // 
            // cmBTaskStatusUpdate
            // 
            this.cmBTaskStatusUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBTaskStatusUpdate.FormattingEnabled = true;
            this.cmBTaskStatusUpdate.Location = new System.Drawing.Point(533, 67);
            this.cmBTaskStatusUpdate.Name = "cmBTaskStatusUpdate";
            this.cmBTaskStatusUpdate.Size = new System.Drawing.Size(179, 32);
            this.cmBTaskStatusUpdate.TabIndex = 27;
            this.cmBTaskStatusUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBTaskStatusUpdate_MouseClick);
            // 
            // labelPriorityUpdate
            // 
            this.labelPriorityUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriorityUpdate.AutoSize = true;
            this.labelPriorityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriorityUpdate.Location = new System.Drawing.Point(585, 175);
            this.labelPriorityUpdate.Name = "labelPriorityUpdate";
            this.labelPriorityUpdate.Size = new System.Drawing.Size(71, 25);
            this.labelPriorityUpdate.TabIndex = 23;
            this.labelPriorityUpdate.Text = "Priority";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1824, 786);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "Goal and Task Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabGoals.ResumeLayout(false);
            this.tabGoals.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            this.tabTasks.PerformLayout();
            this.tabViewGoals.ResumeLayout(false);
            this.tabViewGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).EndInit();
            this.gBUpdateGoal.ResumeLayout(false);
            this.gBUpdateGoal.PerformLayout();
            this.tabViewTasks.ResumeLayout(false);
            this.tabViewTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.gBUpdateTask.ResumeLayout(false);
            this.gBUpdateTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage tabGoals;
        private System.Windows.Forms.ComboBox cmBCategory;
        private System.Windows.Forms.ComboBox cmBGoalStatus;
        private System.Windows.Forms.DateTimePicker dTPDeadline;
        private System.Windows.Forms.TextBox tBGoalDescription;
        private System.Windows.Forms.TextBox tBGoalName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelGoalDescription;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Button btnCancelGoalAdd;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox cmBTaskStatus;
        private System.Windows.Forms.Label labelTaskStatus;
        private System.Windows.Forms.Label labelTaskDeadline;
        private System.Windows.Forms.DateTimePicker dTPTaskDeadline;
        private System.Windows.Forms.TextBox tBTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.TextBox tBTaskName;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.ComboBox cmBPriority;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ComboBox cmBSelectGoal;
        private System.Windows.Forms.Label labelSelectGoal;
        private System.Windows.Forms.TabPage tabViewGoals;
        private System.Windows.Forms.DataGridView dataGridViewGoals;
        private System.Windows.Forms.DateTimePicker dTPDeadlineFilterTo;
        private System.Windows.Forms.DateTimePicker dTPDeadlineFilterFrom;
        private System.Windows.Forms.ComboBox cmBGStatusFilter;
        private System.Windows.Forms.ComboBox cmBCategoryFilter;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDeadlineFilter;
        private System.Windows.Forms.Label labelGStatusFilter;
        private System.Windows.Forms.Label labelCategoryFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelGoalNameUpdate;
        private System.Windows.Forms.ComboBox cmBCategoryUpdate;
        private System.Windows.Forms.ComboBox cmBGStatusUpdate;
        private System.Windows.Forms.TextBox tBGoalDescriptionUpdate;
        private System.Windows.Forms.TextBox tBGoalNameUpdate;
        private System.Windows.Forms.Label labelGStatusUpdate;
        private System.Windows.Forms.Label labelCategoryUpdate;
        private System.Windows.Forms.Label labelGoalDescriptionUpdate;
        private System.Windows.Forms.Button btnDeleteGoal;
        private System.Windows.Forms.Button btnUpdateGoal;
        private System.Windows.Forms.TabPage tabViewTasks;
        private System.Windows.Forms.Label labelToTask;
        private System.Windows.Forms.Label labelTaskDeadlineFilter;
        private System.Windows.Forms.Label labelTaskStatusFilter;
        private System.Windows.Forms.Label labelGoalForTaskFilter;
        private System.Windows.Forms.DateTimePicker dTPTaskDeadlineTo;
        private System.Windows.Forms.DateTimePicker dTPTaskDeadlineFrom;
        private System.Windows.Forms.ComboBox cmBTaskStatusFilter;
        private System.Windows.Forms.ComboBox cmBGoalForTaskFilter;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Label labeTaskNameUpdate;
        private System.Windows.Forms.ComboBox cmBPriorityUpdate;
        private System.Windows.Forms.ComboBox cmBTaskStatusUpdate;
        private System.Windows.Forms.TextBox tBTaskDescriptionUpdate;
        private System.Windows.Forms.TextBox tBTaskNameUpdate;
        private System.Windows.Forms.Label labelTaskStatusUpdate;
        private System.Windows.Forms.Label labelPriorityUpdate;
        private System.Windows.Forms.Label labelTaskDescriptionUpdate;
        private System.Windows.Forms.Button btnRefreshTask;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.Button btnCloseTask;
        private System.Windows.Forms.Button btnCancelAddTask;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelGoalStatus;
        private System.Windows.Forms.GroupBox gBUpdateGoal;
        private System.Windows.Forms.GroupBox gBUpdateTask;
        private System.Windows.Forms.Label labelFilterGoals;
        private System.Windows.Forms.Label labelModifyGoals;
        private System.Windows.Forms.Label labelModifyTasks;
        private System.Windows.Forms.Label labelFilterTasks;
    }
}

