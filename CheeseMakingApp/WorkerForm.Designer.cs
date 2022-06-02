
namespace CheeseMakingApp
{
    partial class WorkerForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label staffIdLabel;
            System.Windows.Forms.Label processIdLabel;
            System.Windows.Forms.Label locationIdLabel;
            System.Windows.Forms.Label machineryIdLabel;
            System.Windows.Forms.Label completionDateLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label batchIdLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label sortIdLabel;
            System.Windows.Forms.Label dateOfStartLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.labelProcess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cheeseMakingDataSet = new CheeseMakingApp.CheeseMakingDataSet();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.ActivityTableAdapter();
            this.tableAdapterManager = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.TableAdapterManager();
            this.batchesTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.BatchesTableAdapter();
            this.locationsTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.LocationsTableAdapter();
            this.machineryTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.MachineryTableAdapter();
            this.processesTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.ProcessesTableAdapter();
            this.staffTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.StaffTableAdapter();
            this.activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.staffIdComboBox = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processIdComboBox = new System.Windows.Forms.ComboBox();
            this.processesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationIdComboBox = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machineryIdComboBox = new System.Windows.Forms.ComboBox();
            this.machineryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.completionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.batchIdComboBox = new System.Windows.Forms.ComboBox();
            this.batchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOpenTableActivity = new System.Windows.Forms.Button();
            this.panelBatches = new System.Windows.Forms.Panel();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.sortIdComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBatches = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            staffIdLabel = new System.Windows.Forms.Label();
            processIdLabel = new System.Windows.Forms.Label();
            locationIdLabel = new System.Windows.Forms.Label();
            machineryIdLabel = new System.Windows.Forms.Label();
            completionDateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            batchIdLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            sortIdLabel = new System.Windows.Forms.Label();
            dateOfStartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseMakingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).BeginInit();
            this.activityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineryBindingSource)).BeginInit();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource1)).BeginInit();
            this.panelBatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // staffIdLabel
            // 
            staffIdLabel.AutoSize = true;
            staffIdLabel.Location = new System.Drawing.Point(12, 53);
            staffIdLabel.Name = "staffIdLabel";
            staffIdLabel.Size = new System.Drawing.Size(44, 13);
            staffIdLabel.TabIndex = 5;
            staffIdLabel.Text = "Staff Id:";
            // 
            // processIdLabel
            // 
            processIdLabel.AutoSize = true;
            processIdLabel.Location = new System.Drawing.Point(12, 80);
            processIdLabel.Name = "processIdLabel";
            processIdLabel.Size = new System.Drawing.Size(60, 13);
            processIdLabel.TabIndex = 7;
            processIdLabel.Text = "Process Id:";
            // 
            // locationIdLabel
            // 
            locationIdLabel.AutoSize = true;
            locationIdLabel.Location = new System.Drawing.Point(12, 134);
            locationIdLabel.Name = "locationIdLabel";
            locationIdLabel.Size = new System.Drawing.Size(63, 13);
            locationIdLabel.TabIndex = 11;
            locationIdLabel.Text = "Location Id:";
            // 
            // machineryIdLabel
            // 
            machineryIdLabel.AutoSize = true;
            machineryIdLabel.Location = new System.Drawing.Point(12, 161);
            machineryIdLabel.Name = "machineryIdLabel";
            machineryIdLabel.Size = new System.Drawing.Size(71, 13);
            machineryIdLabel.TabIndex = 13;
            machineryIdLabel.Text = "Machinery Id:";
            // 
            // completionDateLabel
            // 
            completionDateLabel.AutoSize = true;
            completionDateLabel.Location = new System.Drawing.Point(12, 189);
            completionDateLabel.Name = "completionDateLabel";
            completionDateLabel.Size = new System.Drawing.Size(88, 13);
            completionDateLabel.TabIndex = 15;
            completionDateLabel.Text = "Completion Date:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 214);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 17;
            commentLabel.Text = "Comment:";
            // 
            // batchIdLabel
            // 
            batchIdLabel.AutoSize = true;
            batchIdLabel.Location = new System.Drawing.Point(12, 107);
            batchIdLabel.Name = "batchIdLabel";
            batchIdLabel.Size = new System.Drawing.Size(50, 13);
            batchIdLabel.TabIndex = 9;
            batchIdLabel.Text = "Batch Id:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(22, 21);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Id:";
            // 
            // sortIdLabel
            // 
            sortIdLabel.AutoSize = true;
            sortIdLabel.Location = new System.Drawing.Point(22, 47);
            sortIdLabel.Name = "sortIdLabel";
            sortIdLabel.Size = new System.Drawing.Size(41, 13);
            sortIdLabel.TabIndex = 2;
            sortIdLabel.Text = "Sort Id:";
            // 
            // dateOfStartLabel
            // 
            dateOfStartLabel.AutoSize = true;
            dateOfStartLabel.Location = new System.Drawing.Point(22, 75);
            dateOfStartLabel.Name = "dateOfStartLabel";
            dateOfStartLabel.Size = new System.Drawing.Size(72, 13);
            dateOfStartLabel.TabIndex = 4;
            dateOfStartLabel.Text = "Date Of Start:";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelProcess.Location = new System.Drawing.Point(579, 64);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(209, 39);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "next process";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(291, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Next thing to do about batch ";
            // 
            // cheeseMakingDataSet
            // 
            this.cheeseMakingDataSet.DataSetName = "CheeseMakingDataSet";
            this.cheeseMakingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = null;
            this.tableAdapterManager.ActivityTableAdapter = this.activityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BatchesTableAdapter = this.batchesTableAdapter;
            this.tableAdapterManager.BatchFormulaTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.IngredientsInBatchTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.JobPositionsTableAdapter = null;
            this.tableAdapterManager.JobsByTypesTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = this.locationsTableAdapter;
            this.tableAdapterManager.MachineryTableAdapter = this.machineryTableAdapter;
            this.tableAdapterManager.ProcessesTableAdapter = this.processesTableAdapter;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.PurshasingIngredientsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.SortsInSalesTableAdapter = null;
            this.tableAdapterManager.SortsTableAdapter = null;
            this.tableAdapterManager.StaffAccountsTableAdapter = null;
            this.tableAdapterManager.StaffPositionsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.StagesTableAdapter = null;
            this.tableAdapterManager.SupliersTableAdapter = null;
            this.tableAdapterManager.TypesOfJobsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CheeseMakingApp.CheeseMakingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // batchesTableAdapter
            // 
            this.batchesTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // machineryTableAdapter
            // 
            this.machineryTableAdapter.ClearBeforeFill = true;
            // 
            // processesTableAdapter
            // 
            this.processesTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // activityBindingNavigator
            // 
            this.activityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activityBindingNavigator.BindingSource = this.activityBindingSource;
            this.activityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.activityBindingNavigatorSaveItem});
            this.activityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityBindingNavigator.Name = "activityBindingNavigator";
            this.activityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activityBindingNavigator.Size = new System.Drawing.Size(822, 25);
            this.activityBindingNavigator.TabIndex = 1;
            this.activityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // activityBindingNavigatorSaveItem
            // 
            this.activityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activityBindingNavigatorSaveItem.Image")));
            this.activityBindingNavigatorSaveItem.Name = "activityBindingNavigatorSaveItem";
            this.activityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.activityBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.activityBindingNavigatorSaveItem.Click += new System.EventHandler(this.activityBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(106, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // staffIdComboBox
            // 
            this.staffIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "StaffId", true));
            this.staffIdComboBox.DataSource = this.staffBindingSource;
            this.staffIdComboBox.DisplayMember = "FirstName";
            this.staffIdComboBox.FormattingEnabled = true;
            this.staffIdComboBox.Location = new System.Drawing.Point(106, 50);
            this.staffIdComboBox.Name = "staffIdComboBox";
            this.staffIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.staffIdComboBox.TabIndex = 6;
            this.staffIdComboBox.ValueMember = "Id";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // processIdComboBox
            // 
            this.processIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "ProcessId", true));
            this.processIdComboBox.DataSource = this.processesBindingSource;
            this.processIdComboBox.DisplayMember = "_name";
            this.processIdComboBox.FormattingEnabled = true;
            this.processIdComboBox.Location = new System.Drawing.Point(106, 77);
            this.processIdComboBox.Name = "processIdComboBox";
            this.processIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.processIdComboBox.TabIndex = 8;
            this.processIdComboBox.ValueMember = "Id";
            // 
            // processesBindingSource
            // 
            this.processesBindingSource.DataMember = "Processes";
            this.processesBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // locationIdComboBox
            // 
            this.locationIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "LocationId", true));
            this.locationIdComboBox.DataSource = this.locationsBindingSource;
            this.locationIdComboBox.DisplayMember = "_name";
            this.locationIdComboBox.FormattingEnabled = true;
            this.locationIdComboBox.Location = new System.Drawing.Point(106, 131);
            this.locationIdComboBox.Name = "locationIdComboBox";
            this.locationIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.locationIdComboBox.TabIndex = 12;
            this.locationIdComboBox.ValueMember = "Id";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // machineryIdComboBox
            // 
            this.machineryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "MachineryId", true));
            this.machineryIdComboBox.DataSource = this.machineryBindingSource;
            this.machineryIdComboBox.DisplayMember = "_name";
            this.machineryIdComboBox.FormattingEnabled = true;
            this.machineryIdComboBox.Location = new System.Drawing.Point(106, 158);
            this.machineryIdComboBox.Name = "machineryIdComboBox";
            this.machineryIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.machineryIdComboBox.TabIndex = 14;
            this.machineryIdComboBox.ValueMember = "Id";
            // 
            // machineryBindingSource
            // 
            this.machineryBindingSource.DataMember = "Machinery";
            this.machineryBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // completionDateDateTimePicker
            // 
            this.completionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "CompletionDate", true));
            this.completionDateDateTimePicker.Location = new System.Drawing.Point(106, 185);
            this.completionDateDateTimePicker.Name = "completionDateDateTimePicker";
            this.completionDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.completionDateDateTimePicker.TabIndex = 16;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(106, 211);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentTextBox.TabIndex = 18;
            // 
            // panelActivity
            // 
            this.panelActivity.Controls.Add(idLabel);
            this.panelActivity.Controls.Add(this.idTextBox);
            this.panelActivity.Controls.Add(staffIdLabel);
            this.panelActivity.Controls.Add(this.staffIdComboBox);
            this.panelActivity.Controls.Add(processIdLabel);
            this.panelActivity.Controls.Add(this.processIdComboBox);
            this.panelActivity.Controls.Add(batchIdLabel);
            this.panelActivity.Controls.Add(this.batchIdComboBox);
            this.panelActivity.Controls.Add(locationIdLabel);
            this.panelActivity.Controls.Add(this.locationIdComboBox);
            this.panelActivity.Controls.Add(machineryIdLabel);
            this.panelActivity.Controls.Add(this.machineryIdComboBox);
            this.panelActivity.Controls.Add(completionDateLabel);
            this.panelActivity.Controls.Add(this.completionDateDateTimePicker);
            this.panelActivity.Controls.Add(commentLabel);
            this.panelActivity.Controls.Add(this.commentTextBox);
            this.panelActivity.Location = new System.Drawing.Point(30, 150);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(332, 248);
            this.panelActivity.TabIndex = 19;
            this.panelActivity.MouseEnter += new System.EventHandler(this.panelActivity_MouseEnter);
            // 
            // batchIdComboBox
            // 
            this.batchIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "BatchId", true));
            this.batchIdComboBox.DataSource = this.batchesBindingSource;
            this.batchIdComboBox.DisplayMember = "Id";
            this.batchIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batchIdComboBox.FormattingEnabled = true;
            this.batchIdComboBox.Location = new System.Drawing.Point(106, 104);
            this.batchIdComboBox.Name = "batchIdComboBox";
            this.batchIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.batchIdComboBox.TabIndex = 10;
            this.batchIdComboBox.ValueMember = "Id";
            // 
            // batchesBindingSource
            // 
            this.batchesBindingSource.DataMember = "Batches";
            this.batchesBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // batchesBindingSource1
            // 
            this.batchesBindingSource1.DataMember = "Batches";
            this.batchesBindingSource1.DataSource = this.cheeseMakingDataSet;
            // 
            // buttonOpenTableActivity
            // 
            this.buttonOpenTableActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTableActivity.Location = new System.Drawing.Point(30, 404);
            this.buttonOpenTableActivity.Name = "buttonOpenTableActivity";
            this.buttonOpenTableActivity.Size = new System.Drawing.Size(332, 38);
            this.buttonOpenTableActivity.TabIndex = 21;
            this.buttonOpenTableActivity.Text = "Activity";
            this.buttonOpenTableActivity.UseVisualStyleBackColor = true;
            this.buttonOpenTableActivity.Click += new System.EventHandler(this.buttonOpenTableActivity_Click);
            // 
            // panelBatches
            // 
            this.panelBatches.Controls.Add(idLabel1);
            this.panelBatches.Controls.Add(this.idTextBox1);
            this.panelBatches.Controls.Add(sortIdLabel);
            this.panelBatches.Controls.Add(this.sortIdComboBox);
            this.panelBatches.Controls.Add(dateOfStartLabel);
            this.panelBatches.Controls.Add(this.dateOfStartDateTimePicker);
            this.panelBatches.Location = new System.Drawing.Point(440, 150);
            this.panelBatches.Name = "panelBatches";
            this.panelBatches.Size = new System.Drawing.Size(332, 248);
            this.panelBatches.TabIndex = 0;
            this.panelBatches.MouseEnter += new System.EventHandler(this.panelBatches_MouseEnter);
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchesBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(100, 18);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(200, 20);
            this.idTextBox1.TabIndex = 1;
            // 
            // sortIdComboBox
            // 
            this.sortIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchesBindingSource, "SortId", true));
            this.sortIdComboBox.FormattingEnabled = true;
            this.sortIdComboBox.Location = new System.Drawing.Point(100, 44);
            this.sortIdComboBox.Name = "sortIdComboBox";
            this.sortIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.sortIdComboBox.TabIndex = 3;
            // 
            // dateOfStartDateTimePicker
            // 
            this.dateOfStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchesBindingSource, "DateOfStart", true));
            this.dateOfStartDateTimePicker.Location = new System.Drawing.Point(100, 71);
            this.dateOfStartDateTimePicker.Name = "dateOfStartDateTimePicker";
            this.dateOfStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfStartDateTimePicker.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(440, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Batches";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxBatches
            // 
            this.comboBoxBatches.DataSource = this.batchesBindingSource1;
            this.comboBoxBatches.DisplayMember = "Id";
            this.comboBoxBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.comboBoxBatches.FormattingEnabled = true;
            this.comboBoxBatches.Location = new System.Drawing.Point(730, 22);
            this.comboBoxBatches.Name = "comboBoxBatches";
            this.comboBoxBatches.Size = new System.Drawing.Size(49, 46);
            this.comboBoxBatches.TabIndex = 20;
            this.comboBoxBatches.ValueMember = "Id";
            this.comboBoxBatches.SelectedIndexChanged += new System.EventHandler(this.comboBoxBatches_SelectedIndexChanged);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.panelBatches);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpenTableActivity);
            this.Controls.Add(this.comboBoxBatches);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.activityBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProcess);
            this.Name = "WorkerForm";
            this.Text = "Worker Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkerForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cheeseMakingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).EndInit();
            this.activityBindingNavigator.ResumeLayout(false);
            this.activityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineryBindingSource)).EndInit();
            this.panelActivity.ResumeLayout(false);
            this.panelActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource1)).EndInit();
            this.panelBatches.ResumeLayout(false);
            this.panelBatches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label label1;
        private CheeseMakingDataSet cheeseMakingDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private CheeseMakingDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
        private CheeseMakingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton activityBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox staffIdComboBox;
        private System.Windows.Forms.ComboBox processIdComboBox;
        private System.Windows.Forms.ComboBox locationIdComboBox;
        private System.Windows.Forms.ComboBox machineryIdComboBox;
        private System.Windows.Forms.DateTimePicker completionDateDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.ComboBox batchIdComboBox;
        private System.Windows.Forms.Button buttonOpenTableActivity;
        private CheeseMakingDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Panel panelBatches;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private CheeseMakingDataSetTableAdapters.ProcessesTableAdapter processesTableAdapter;
        private System.Windows.Forms.BindingSource processesBindingSource;
        private CheeseMakingDataSetTableAdapters.BatchesTableAdapter batchesTableAdapter;
        private System.Windows.Forms.BindingSource batchesBindingSource;
        private CheeseMakingDataSetTableAdapters.LocationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private CheeseMakingDataSetTableAdapters.MachineryTableAdapter machineryTableAdapter;
        private System.Windows.Forms.BindingSource machineryBindingSource;
        private System.Windows.Forms.BindingSource batchesBindingSource1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.ComboBox sortIdComboBox;
        private System.Windows.Forms.DateTimePicker dateOfStartDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxBatches;
    }
}