
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using GoalTask.Data.Enums;


namespace GoalTask.Desktop
{
    public partial class MainForm : Form
    {

        public UIHelper UIHelper { get; set; }
        internal int goalID;
        internal int taskID;
        public string ErrorMessage { get; set; }

        public string GoalName {
                get { return tBGoalName.Text.Trim();}
               set { tBGoalName.Text = value; }
        }

        public string GoalDescription {
            get {return tBGoalDescription.Text ;}
            set { tBGoalDescription.Text = value; }
        }

        public DateTime GoalDeadline {
            get { return dTPDeadline.Value; }
        }

        public int GoalStatus {
            get { return (int)cmBGoalStatus.SelectedValue; }
            set { cmBGoalStatus.SelectedValue = value; }
        }

        public int Category {
            get { return (int)cmBCategory.SelectedValue; }
            set { cmBCategory.SelectedValue = value; }
        }

        public string TaskName
        {
            get { return tBTaskName.Text; }
            set { tBTaskName.Text = value; }
        }

        public string TaskDescription
        {
            get { return tBTaskDescription.Text; }
            set { tBTaskDescription.Text = value; }
        }

        public DateTime TaskDeadline
        {
            get { return dTPTaskDeadline.Value; }
            set { dTPTaskDeadline.Value = value; }
        }

        public int Priority
        {
            get { return (int)cmBPriority.SelectedValue; }
            set { cmBPriority.SelectedValue = value; }
        }

        public int TaskStatus
        {
            get { return (int)cmBTaskStatus.SelectedValue; }
            set { cmBTaskStatus.SelectedValue = value; }
        }

        public int SelectedGoalForTask
        {
            get {
                if (cmBSelectGoal.SelectedIndex == -1)
                    return 0;
                else
                {
                    return (int)cmBSelectGoal.SelectedValue;
                }
            }
            set { cmBSelectGoal.SelectedValue = value; }
        }

        public DateTime? DeadlineFilterFrom
        {
            get
            {
                if (dTPDeadlineFilterFrom.Checked == true)
                {
                    return dTPDeadlineFilterFrom.Value;
                }
                else return null;
            }
           
        }

        public DateTime? DeadlineFilterTo
        {
            get
            {
                if (dTPDeadlineFilterTo.Checked == true)
                {
                    return dTPDeadlineFilterTo.Value;
                }
                else return null;
            }
        }
        public int CategoryFilter
        {
            get
            {
                if (cmBCategoryFilter.SelectedIndex == -1)
                {
                    return -1;
                }
                else
                {
                    return (int)cmBCategoryFilter.SelectedValue;
                }
            }
            set { cmBCategoryFilter.SelectedValue = value; }
        }

        public int GStatusFilter
        {
            get
            {
                if (cmBGStatusFilter.SelectedIndex == -1)
                {
                    return -1;
                }
                else
                {
                    return (int)cmBGStatusFilter.SelectedValue;
                }
            }
            set { cmBGStatusFilter.SelectedValue = value; }
        }

        
        public string GoalNameNew
        {
            get { return tBGoalNameUpdate.Text.Trim(); }
            set { tBGoalNameUpdate.Text = value; }
        }

        public string GoalDescriptionNew
        {
            get { return tBGoalDescriptionUpdate.Text; }
            set { tBGoalDescriptionUpdate.Text = value; }
        }

        public int GoalStatusNew
        {
            get { return (int)cmBGStatusUpdate.SelectedValue; }
            set { cmBGStatusUpdate.SelectedValue = value; }
        }

        public int CategoryNew
        {
            get { return (int)cmBCategoryUpdate.SelectedValue; }
            set { cmBCategoryUpdate.SelectedValue = value; }
        }


        public DateTime? TaskDeadlineFilterFrom
        {
            get
            {
                if (dTPTaskDeadlineFrom.Checked == true)
                {
                    return dTPTaskDeadlineFrom.Value;
                }
                else return null;
            }

        }

        public DateTime? TaskDeadlineFilterTo
        {
            get
            {
                if (dTPTaskDeadlineTo.Checked == true)
                {
                    return dTPTaskDeadlineTo.Value;
                }
                else return null;
            }
        }

        public int TaskStatusFilter
        {
            get
            {
                if (cmBTaskStatusFilter.SelectedIndex == -1)
                {
                    return -1;
                }
                else
                {
                    return (int)cmBTaskStatusFilter.SelectedValue;
                }
            }
            set { cmBTaskStatusFilter.SelectedValue = value; }
        }

        public int GoalForTaskFilter
        {
            get
            {
                if(cmBGoalForTaskFilter.SelectedIndex==-1 || (int)cmBGoalForTaskFilter.SelectedValue == 0)
                {
                    return -1;
                }
                else
                {
                    return (int)cmBGoalForTaskFilter.SelectedValue;
                }

            }
        }

        public string TaskNameNew
        {
            get { return tBTaskNameUpdate.Text.Trim(); }
            set { tBTaskNameUpdate.Text = value; }
        }

        public string TaskDescriptionNew
        {
            get { return tBTaskDescriptionUpdate.Text; }
            set { tBTaskDescriptionUpdate.Text = value; }
        }

        public int TaskStatusNew
        {
            get { return (int)cmBTaskStatusUpdate.SelectedValue; }
            set { cmBTaskStatusUpdate.SelectedValue = value; }
        }

       public object PriorityNew
        {
            get { return (int)cmBPriorityUpdate.SelectedValue; }
            set { cmBPriorityUpdate.SelectedItem = (TaskPriority)value; }
        }  

        public MainForm()
        {
            UIHelper = new UIHelper(this);
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            try
            {
                UIHelper.AddGoal();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }

        }


        private void btnCancelGoalAdd_Click(object sender, EventArgs e)
        {

            try
            {
                UIHelper.ClearFieldsGoal();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBGoalStatus_Click(object sender, EventArgs e)
        {
            try
            {
                IntializeStatus(cmBGoalStatus);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBCategory_Click(object sender, EventArgs e)
        {
            try
            {
                IntializeCategory(cmBCategory);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                UIHelper.AddTask();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBTaskStatus_Click(object sender, EventArgs e)
        {
            try
            {
                IntializeStatus(cmBTaskStatus);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBPriority_Click(object sender, EventArgs e)
        {
            try
            {
                IntializePriority(cmBPriority);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void IntializeCategory(ComboBox cmBCategory)
        {
            DataTable dataTable =UIHelper.ViewCategory();
            cmBCategory.DisplayMember = dataTable.Columns[1].ColumnName;
            cmBCategory.ValueMember = dataTable.Columns[0].ColumnName;
            cmBCategory.DataSource = dataTable;
            cmBCategory.SelectedIndex = -1;

        }

        private void IntializeStatus(ComboBox cmBStatus)
        {
            DataTable dataTable = UIHelper.ViewStatus();
            
            cmBStatus.DisplayMember = dataTable.Columns[1].ColumnName;
            cmBStatus.ValueMember = dataTable.Columns[0].ColumnName;           
            cmBStatus.DataSource = dataTable;
            cmBStatus.SelectedIndex = -1;
            
        }

        private void IntializePriority(ComboBox cmBPriority)
        {
            cmBPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            cmBPriority.SelectedIndex = -1;
        }

        private void IntializeGoalName(ComboBox cmBGoalName)
        {
            DataTable dataTable = UIHelper.ViewGoalName();
            dataTable.Rows.Add(0, "None");
            cmBGoalName.DisplayMember = dataTable.Columns[1].ColumnName;
            cmBGoalName.ValueMember = dataTable.Columns[0].ColumnName;
            cmBGoalName.DataSource = dataTable;
            cmBGoalName.SelectedIndex = -1;
            
        }

        private void cmBSelectGoal_Click(object sender, EventArgs e)
        {
            try
            {
                IntializeGoalName(cmBSelectGoal);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        internal void LoadDataGridViewGoals(DataTable data)
        {
            dataGridViewGoals.DataSource = data;
            dataGridViewGoals.Columns["GoalID"].Visible = false;
            dataGridViewGoals.DataMember = data.TableName;
            IntializeDataGridViewStyle(dataGridViewGoals);
        }

        internal void LoadDataGridViewTasks(DataTable data)
        {
            dataGridViewTasks.DataSource = data;
            dataGridViewTasks.Columns["TaskID"].Visible = false;
            dataGridViewTasks.DataMember = data.TableName;
            IntializeDataGridViewStyle(dataGridViewTasks);
     
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewGoals.Visible = false;
            gBUpdateGoal.Visible = false;
            dataGridViewTasks.Visible = false;
            gBUpdateTask.Visible = false;

            try
            {

                if (tabControlMain.SelectedIndex == 0)
                {
                    this.AcceptButton = btnAddGoal;
                    this.CancelButton = btnCancelGoalAdd;
                }



                if (tabControlMain.SelectedIndex == 2)
                {
                    ResetSearchGoals();
                    DataTable goals = UIHelper.ViewAllGoals();
                    LoadDataGridViewGoals(goals);
                    IntializeCategory(cmBCategoryUpdate);
                    IntializeStatus(cmBGStatusUpdate);
                }

                if (tabControlMain.SelectedIndex == 3)
                {
                    ResetSearchTasks();
                    DataTable tasks = UIHelper.ViewallTasks();
                    LoadDataGridViewTasks(tasks);
                    IntializeStatus(cmBTaskStatusUpdate);
                    IntializePriority(cmBPriorityUpdate);

                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }

        }


        private void cmBCategoryFilter_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IntializeCategory(cmBCategoryFilter);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBGStatusFilter_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IntializeStatus(cmBGStatusFilter);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFilterGoals())
                {
                    DataTable data = UIHelper.FilterGoals();
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show(Resources.FilterGoals_NoData_Message,
                            Resources.Error_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        LoadDataGridViewGoals(data);
                        dataGridViewGoals.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show(ErrorMessage,
                        Resources.Error_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

       

        private void cmBGoalForTaskFilter_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IntializeGoalName(cmBGoalForTaskFilter);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBTaskStatusFilter_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IntializeStatus(cmBTaskStatusFilter);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBTaskStatusUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IntializeStatus(cmBTaskStatusUpdate);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void cmBPriorityUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IntializePriority(cmBPriorityUpdate);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        
        private void dataGridViewGoals_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    gBUpdateGoal.Visible = true;
                    String sGoalID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    goalID = int.Parse(sGoalID);
                    DataRow dataRow = UIHelper.ViewGoalById(goalID);

                    GoalNameNew = dataRow["GoalName"].ToString();
                    GoalDescriptionNew = dataRow["GoalDescription"].ToString();
                    GoalStatusNew = (int) dataRow["GoalStatus"];
                    CategoryNew = (int) dataRow["CategoryID"];
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }

        }


        private void btnUpdateGoal_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUpdateGoal())
                {
                    UIHelper.UpdateGoal();
                }
                else
                {
                    MessageBox.Show(ErrorMessage,
                        Resources.Error_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            try
            {
                UIHelper.DeleteGoal();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnSearchTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFilterTasks())
                {
                    DataTable data = UIHelper.FilterTasks();
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show(Resources.FilterTasks_NoData_Message,
                            Resources.Error_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadDataGridViewTasks(data);
                        dataGridViewTasks.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show(ErrorMessage,
                        Resources.Error_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void dataGridViewTasks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView) sender;

                if (dgv.SelectedRows.Count > 0)
                {
                    gBUpdateTask.Visible = true;
                    String sTaskID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    taskID = int.Parse(sTaskID);
                    DataRow dataRow = UIHelper.ViewTaskByID(taskID);

                    TaskNameNew = dataRow["TaskName"].ToString();
                    TaskDescriptionNew = dataRow["TaskDescription"].ToString();
                    TaskStatusNew = (int) dataRow["TaskStatus"];
                    PriorityNew = dataRow["Priority"];

                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUpdateTask())
                {
                    UIHelper.UpdateTask();
                }
                else
                {
                    MessageBox.Show(ErrorMessage,
                        Resources.Error_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                UIHelper.DeleteTask();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnCloseTask_Click(object sender, EventArgs e)
        {
            try
            {
                UIHelper.CloseTask();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void ResetSearchGoals()
        {
            cmBCategoryFilter.SelectedIndex = -1;
            cmBGStatusFilter.SelectedIndex = -1;
            dTPDeadlineFilterFrom.Checked = false;
            dTPDeadlineFilterTo.Checked = false;
        }

        private void ResetSearchTasks()
        {
            cmBGoalForTaskFilter.SelectedIndex = -1;
            cmBTaskStatusFilter.SelectedIndex = -1;
            dTPTaskDeadlineFrom.Checked = false;
            dTPTaskDeadlineTo.Checked = false;
        }

        internal bool ValidateAddGoal()
        {
            ErrorMessage = string.Empty;
            if (GoalName == string.Empty)
            {
                UIHelper.AddErrorMessage(Resources.AddGoal_GoalName_Empty);
            }

            if(GoalDeadline < DateTime.Today)
            {
                UIHelper.AddErrorMessage(Resources.AddGoal_Deadline_Valid);
            }

            if (cmBGoalStatus.SelectedIndex == -1)
            {
                UIHelper.AddErrorMessage(Resources.AddGoal_GoalStatus_Select);
            }

            if(cmBCategory.SelectedIndex == -1)
            {
                UIHelper.AddErrorMessage(Resources.AddGoal_GoalCategory_Select);
            }

            return ErrorMessage != string.Empty ? false : true;
        }

        internal bool ValidateAddTask()
        {
            ErrorMessage = string.Empty;
            if (TaskName == string.Empty)
            {
                UIHelper.AddErrorMessage(Resources.AddTask_TaskName_Empty);
            }

            if (TaskDeadline < DateTime.Today)
            {
                UIHelper.AddErrorMessage(Resources.AddTask_Deadline_Valid);
            }

            if (cmBTaskStatus.SelectedIndex == -1)
            {
                UIHelper.AddErrorMessage(Resources.AddTask_TaskStatus_Select);
            }
            if (cmBPriority.SelectedIndex == -1)
            {
                UIHelper.AddErrorMessage(Resources.AddTask_TaskPriority_Select);
            }

            return ErrorMessage != string.Empty ? false : true;
        }

        internal bool ValidateFilterGoals()
        {
            ErrorMessage = string.Empty;
            if (dTPDeadlineFilterFrom.Checked && dTPDeadlineFilterTo.Checked) {
                if (DeadlineFilterFrom > DeadlineFilterTo)
                {
                    UIHelper.AddErrorMessage(Resources.FilterGoals_DateFilter_fromto);
                }
            }

            return ErrorMessage != string.Empty ? false : true;
        }


        internal bool ValidateFilterTasks()
        {
            ErrorMessage = string.Empty;
            if (dTPTaskDeadlineFrom.Checked  && dTPTaskDeadlineTo.Checked)
            {
                if (TaskDeadlineFilterFrom > TaskDeadlineFilterTo)
                {
                    UIHelper.AddErrorMessage(Resources.FilterTasks_DateFilter_fromto);
                }
            }

            return ErrorMessage != string.Empty ? false : true;
        }

        internal bool ValidateUpdateGoal()
        {
            ErrorMessage = string.Empty;
            if (GoalNameNew == string.Empty)
            {
                UIHelper.AddErrorMessage(Resources.AddGoal_GoalName_Empty);
            }
            return ErrorMessage != string.Empty ? false : true;
        }
    
        internal bool ValidateUpdateTask()
        {
            ErrorMessage = string.Empty;
            if(TaskNameNew == string.Empty)
            {
                UIHelper.AddErrorMessage(Resources.AddTask_TaskName_Empty);
            }
            return ErrorMessage != string.Empty ? false : true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ResetSearchGoals();
                DataTable data = UIHelper.ViewAllGoals();
                LoadDataGridViewGoals(data);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnRefreshTask_Click(object sender, EventArgs e)
        {
            try
            {
                ResetSearchTasks();
                DataTable data = UIHelper.ViewallTasks();
                LoadDataGridViewTasks(data);
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void btnCancelAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                UIHelper.ClearFieldsTask();
            }
            catch (Exception ex)
            {
                UIHelper.ShowErrorMessage(ex);
            }
        }

        private void IntializeDataGridViewStyle(DataGridView dgv)
        {

            int totalRowHeight = dgv.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgv.Rows)
                   totalRowHeight += row.Height;               
           

            dgv.Height = totalRowHeight;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Italic, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaptionText;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = SystemColors.ControlDarkDark;

        }

        private void labelTaskStatusFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
