using System;
using System.Windows.Forms;
using static CheeseMakingApp.Utilities;

namespace CheeseMakingApp
{
    public partial class AccountantForm : Form
    {
        public AccountantForm(LoginForm loginFormGiven)
        {
            InitializeComponent();
            loginFormTaken = loginFormGiven;
        }
        
        private LoginForm loginFormTaken;

        private void purchasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingNavigator.BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cheeseMakingDataSet);
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cheeseMakingDataSet.Supliers". При необходимости она может быть перемещена или удалена.
            this.supliersTableAdapter.Fill(this.cheeseMakingDataSet.Supliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cheeseMakingDataSet.Locations". При необходимости она может быть перемещена или удалена.
            this.locationsTableAdapter.Fill(this.cheeseMakingDataSet.Locations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cheeseMakingDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.cheeseMakingDataSet.Customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cheeseMakingDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.cheeseMakingDataSet.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cheeseMakingDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.cheeseMakingDataSet.Purchases);

        }

        private void AccountantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginFormTaken.Show();
        }

        private void buttonOpenTableSales_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            fillDataGrid("Select Sales.Id, Customers._name, Locations._name, Cost from Sales inner join Customers on Customers.Id = Sales.CustomerId inner join Locations on Locations.Id = Sales.StorageId", tableForm.dataGridView1);
            tableForm.dataGridView1.Columns[1].HeaderText = "Customer";
            tableForm.dataGridView1.Columns[2].HeaderText = "Storage";
            tableForm.dataGridView1.Columns.Add("columnButtons", "Click 2 see sorts");
            tableForm.Text = "Sales";
            tableForm.Show();
        }

        private void panelSales_MouseEnter(object sender, EventArgs e)
        {
            purchasesBindingNavigator.BindingSource = salesBindingSource;
        }

        private void panelPurchases_MouseEnter(object sender, EventArgs e)
        {
            purchasesBindingNavigator.BindingSource = purchasesBindingSource;
        }

        private void buttonOpenTablePurchases_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            fillDataGrid("Select Purchases.Id, Supliers._name, DateOf, Cost from Purchases inner join Supliers on Supliers.Id = SuplierId", tableForm.dataGridView1);
            tableForm.dataGridView1.Columns[1].HeaderText = "Customer";
            tableForm.dataGridView1.Columns.Add("columnButtons", "Click 2 see ingredients");
            tableForm.Text = "Purchases";
            tableForm.Show();
        }
    }
}
