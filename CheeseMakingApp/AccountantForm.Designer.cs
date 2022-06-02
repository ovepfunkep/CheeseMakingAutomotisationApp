
namespace CheeseMakingApp
{
    partial class AccountantForm
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
            System.Windows.Forms.Label suplierIdLabel;
            System.Windows.Forms.Label dateOfLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label storageIdLabel;
            System.Windows.Forms.Label costLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.panelPurchases = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheeseMakingDataSet = new CheeseMakingApp.CheeseMakingDataSet();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.suplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelSales = new System.Windows.Forms.Panel();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageIdComboBox = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costTextBox1 = new System.Windows.Forms.TextBox();
            this.purchasesTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.PurchasesTableAdapter();
            this.tableAdapterManager = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.TableAdapterManager();
            this.salesTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.SalesTableAdapter();
            this.purchasesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchasesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonOpenTablePurchases = new System.Windows.Forms.Button();
            this.buttonOpenTableSales = new System.Windows.Forms.Button();
            this.customersTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.CustomersTableAdapter();
            this.locationsTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.LocationsTableAdapter();
            this.supliersTableAdapter = new CheeseMakingApp.CheeseMakingDataSetTableAdapters.SupliersTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            suplierIdLabel = new System.Windows.Forms.Label();
            dateOfLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            storageIdLabel = new System.Windows.Forms.Label();
            costLabel1 = new System.Windows.Forms.Label();
            this.panelPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseMakingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supliersBindingSource)).BeginInit();
            this.panelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingNavigator)).BeginInit();
            this.purchasesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(39, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // suplierIdLabel
            // 
            suplierIdLabel.AutoSize = true;
            suplierIdLabel.Location = new System.Drawing.Point(39, 56);
            suplierIdLabel.Name = "suplierIdLabel";
            suplierIdLabel.Size = new System.Drawing.Size(42, 13);
            suplierIdLabel.TabIndex = 2;
            suplierIdLabel.Text = "Suplier:";
            // 
            // dateOfLabel
            // 
            dateOfLabel.AutoSize = true;
            dateOfLabel.Location = new System.Drawing.Point(39, 84);
            dateOfLabel.Name = "dateOfLabel";
            dateOfLabel.Size = new System.Drawing.Size(47, 13);
            dateOfLabel.TabIndex = 4;
            dateOfLabel.Text = "Date Of:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(39, 109);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 6;
            costLabel.Text = "Cost:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(59, 30);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Id:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(59, 56);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(54, 13);
            customerIdLabel.TabIndex = 2;
            customerIdLabel.Text = "Customer:";
            // 
            // storageIdLabel
            // 
            storageIdLabel.AutoSize = true;
            storageIdLabel.Location = new System.Drawing.Point(59, 83);
            storageIdLabel.Name = "storageIdLabel";
            storageIdLabel.Size = new System.Drawing.Size(47, 13);
            storageIdLabel.TabIndex = 4;
            storageIdLabel.Text = "Storage:";
            // 
            // costLabel1
            // 
            costLabel1.AutoSize = true;
            costLabel1.Location = new System.Drawing.Point(59, 110);
            costLabel1.Name = "costLabel1";
            costLabel1.Size = new System.Drawing.Size(31, 13);
            costLabel1.TabIndex = 6;
            costLabel1.Text = "Cost:";
            // 
            // panelPurchases
            // 
            this.panelPurchases.Controls.Add(idLabel);
            this.panelPurchases.Controls.Add(this.idTextBox);
            this.panelPurchases.Controls.Add(this.costTextBox);
            this.panelPurchases.Controls.Add(suplierIdLabel);
            this.panelPurchases.Controls.Add(costLabel);
            this.panelPurchases.Controls.Add(this.suplierIdComboBox);
            this.panelPurchases.Controls.Add(this.dateOfDateTimePicker);
            this.panelPurchases.Controls.Add(dateOfLabel);
            this.panelPurchases.Location = new System.Drawing.Point(387, 90);
            this.panelPurchases.Name = "panelPurchases";
            this.panelPurchases.Size = new System.Drawing.Size(335, 248);
            this.panelPurchases.TabIndex = 22;
            this.panelPurchases.MouseEnter += new System.EventHandler(this.panelPurchases_MouseEnter);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(99, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // cheeseMakingDataSet
            // 
            this.cheeseMakingDataSet.DataSetName = "CheeseMakingDataSet";
            this.cheeseMakingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasesBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(99, 106);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 7;
            // 
            // suplierIdComboBox
            // 
            this.suplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchasesBindingSource, "SuplierId", true));
            this.suplierIdComboBox.DataSource = this.supliersBindingSource;
            this.suplierIdComboBox.DisplayMember = "_name";
            this.suplierIdComboBox.FormattingEnabled = true;
            this.suplierIdComboBox.Location = new System.Drawing.Point(99, 53);
            this.suplierIdComboBox.Name = "suplierIdComboBox";
            this.suplierIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.suplierIdComboBox.TabIndex = 3;
            this.suplierIdComboBox.ValueMember = "Id";
            // 
            // supliersBindingSource
            // 
            this.supliersBindingSource.DataMember = "Supliers";
            this.supliersBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // dateOfDateTimePicker
            // 
            this.dateOfDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchasesBindingSource, "DateOf", true));
            this.dateOfDateTimePicker.Location = new System.Drawing.Point(99, 80);
            this.dateOfDateTimePicker.Name = "dateOfDateTimePicker";
            this.dateOfDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfDateTimePicker.TabIndex = 5;
            // 
            // panelSales
            // 
            this.panelSales.Controls.Add(idLabel1);
            this.panelSales.Controls.Add(this.idTextBox1);
            this.panelSales.Controls.Add(customerIdLabel);
            this.panelSales.Controls.Add(this.customerIdComboBox);
            this.panelSales.Controls.Add(storageIdLabel);
            this.panelSales.Controls.Add(this.storageIdComboBox);
            this.panelSales.Controls.Add(costLabel1);
            this.panelSales.Controls.Add(this.costTextBox1);
            this.panelSales.Location = new System.Drawing.Point(18, 90);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(332, 248);
            this.panelSales.TabIndex = 23;
            this.panelSales.MouseEnter += new System.EventHandler(this.panelSales_MouseEnter);
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(131, 27);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(121, 20);
            this.idTextBox1.TabIndex = 1;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerId", true));
            this.customerIdComboBox.DataSource = this.customersBindingSource;
            this.customerIdComboBox.DisplayMember = "_name";
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(131, 53);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerIdComboBox.TabIndex = 3;
            this.customerIdComboBox.ValueMember = "Id";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // storageIdComboBox
            // 
            this.storageIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "StorageId", true));
            this.storageIdComboBox.DataSource = this.locationsBindingSource;
            this.storageIdComboBox.DisplayMember = "_name";
            this.storageIdComboBox.FormattingEnabled = true;
            this.storageIdComboBox.Location = new System.Drawing.Point(131, 80);
            this.storageIdComboBox.Name = "storageIdComboBox";
            this.storageIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.storageIdComboBox.TabIndex = 5;
            this.storageIdComboBox.ValueMember = "Id";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.cheeseMakingDataSet;
            // 
            // costTextBox1
            // 
            this.costTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Cost", true));
            this.costTextBox1.Location = new System.Drawing.Point(131, 107);
            this.costTextBox1.Name = "costTextBox1";
            this.costTextBox1.Size = new System.Drawing.Size(121, 20);
            this.costTextBox1.TabIndex = 7;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = null;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BatchesTableAdapter = null;
            this.tableAdapterManager.BatchFormulaTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.IngredientsInBatchTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.JobPositionsTableAdapter = null;
            this.tableAdapterManager.JobsByTypesTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MachineryTableAdapter = null;
            this.tableAdapterManager.ProcessesTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = this.purchasesTableAdapter;
            this.tableAdapterManager.PurshasingIngredientsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.SortsInSalesTableAdapter = null;
            this.tableAdapterManager.SortsTableAdapter = null;
            this.tableAdapterManager.StaffAccountsTableAdapter = null;
            this.tableAdapterManager.StaffPositionsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StagesTableAdapter = null;
            this.tableAdapterManager.SupliersTableAdapter = null;
            this.tableAdapterManager.TypesOfJobsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CheeseMakingApp.CheeseMakingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // purchasesBindingNavigator
            // 
            this.purchasesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchasesBindingNavigator.BindingSource = this.purchasesBindingSource;
            this.purchasesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchasesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchasesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchasesBindingNavigatorSaveItem});
            this.purchasesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchasesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchasesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchasesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchasesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchasesBindingNavigator.Name = "purchasesBindingNavigator";
            this.purchasesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchasesBindingNavigator.Size = new System.Drawing.Size(743, 25);
            this.purchasesBindingNavigator.TabIndex = 26;
            this.purchasesBindingNavigator.Text = "bindingNavigator1";
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
            // purchasesBindingNavigatorSaveItem
            // 
            this.purchasesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchasesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchasesBindingNavigatorSaveItem.Image")));
            this.purchasesBindingNavigatorSaveItem.Name = "purchasesBindingNavigatorSaveItem";
            this.purchasesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purchasesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purchasesBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchasesBindingNavigatorSaveItem_Click);
            // 
            // buttonOpenTablePurchases
            // 
            this.buttonOpenTablePurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTablePurchases.Location = new System.Drawing.Point(387, 344);
            this.buttonOpenTablePurchases.Name = "buttonOpenTablePurchases";
            this.buttonOpenTablePurchases.Size = new System.Drawing.Size(332, 38);
            this.buttonOpenTablePurchases.TabIndex = 27;
            this.buttonOpenTablePurchases.Text = "Purchases";
            this.buttonOpenTablePurchases.UseVisualStyleBackColor = true;
            this.buttonOpenTablePurchases.Click += new System.EventHandler(this.buttonOpenTablePurchases_Click);
            // 
            // buttonOpenTableSales
            // 
            this.buttonOpenTableSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTableSales.Location = new System.Drawing.Point(18, 344);
            this.buttonOpenTableSales.Name = "buttonOpenTableSales";
            this.buttonOpenTableSales.Size = new System.Drawing.Size(332, 38);
            this.buttonOpenTableSales.TabIndex = 28;
            this.buttonOpenTableSales.Text = "Sales";
            this.buttonOpenTableSales.UseVisualStyleBackColor = true;
            this.buttonOpenTableSales.Click += new System.EventHandler(this.buttonOpenTableSales_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // supliersTableAdapter
            // 
            this.supliersTableAdapter.ClearBeforeFill = true;
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.buttonOpenTablePurchases);
            this.Controls.Add(this.buttonOpenTableSales);
            this.Controls.Add(this.purchasesBindingNavigator);
            this.Controls.Add(this.panelPurchases);
            this.Controls.Add(this.panelSales);
            this.Name = "AccountantForm";
            this.Text = "Accountant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountantForm_FormClosed);
            this.Load += new System.EventHandler(this.Accountant_Load);
            this.panelPurchases.ResumeLayout(false);
            this.panelPurchases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseMakingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supliersBindingSource)).EndInit();
            this.panelSales.ResumeLayout(false);
            this.panelSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingNavigator)).EndInit();
            this.purchasesBindingNavigator.ResumeLayout(false);
            this.purchasesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPurchases;
        private System.Windows.Forms.Panel panelSales;
        private CheeseMakingDataSet cheeseMakingDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private CheeseMakingDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private CheeseMakingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchasesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchasesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.ComboBox suplierIdComboBox;
        private System.Windows.Forms.DateTimePicker dateOfDateTimePicker;
        private CheeseMakingDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.ComboBox storageIdComboBox;
        private System.Windows.Forms.TextBox costTextBox1;
        private System.Windows.Forms.Button buttonOpenTablePurchases;
        private System.Windows.Forms.Button buttonOpenTableSales;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CheeseMakingDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private CheeseMakingDataSetTableAdapters.LocationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource supliersBindingSource;
        private CheeseMakingDataSetTableAdapters.SupliersTableAdapter supliersTableAdapter;
    }
}