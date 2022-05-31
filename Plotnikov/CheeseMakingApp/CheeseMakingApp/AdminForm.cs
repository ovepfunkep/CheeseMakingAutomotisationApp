using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CheeseMakingApp.Utilities;

namespace CheeseMakingApp
{
    public partial class AdminForm : Form
    {

        public AdminForm(LoginForm loginFormGiven)
        {
            InitializeComponent();
            loginFormTaken = loginFormGiven;
        }

        private LoginForm loginFormTaken;

        private void fillAll()
        {
            this.activityTableAdapter.Fill(this.cheeseMakingDataSet.Activity);
            this.batchesTableAdapter.Fill(this.cheeseMakingDataSet.Batches);
            this.batchesTableAdapter.Fill(this.cheeseMakingDataSet.Batches);
            this.sortsInSalesTableAdapter.Fill(this.cheeseMakingDataSet.SortsInSales);
            this.salesTableAdapter.Fill(this.cheeseMakingDataSet.Sales);
            this.customersTableAdapter.Fill(this.cheeseMakingDataSet.Customers);
            this.locationsTableAdapter.Fill(this.cheeseMakingDataSet.Locations);
            this.ingredientsInBatchTableAdapter.Fill(this.cheeseMakingDataSet.IngredientsInBatch);
            this.batchFormulaTableAdapter.Fill(this.cheeseMakingDataSet.BatchFormula);
            this.sortsTableAdapter.Fill(this.cheeseMakingDataSet.Sorts);
            this.purshasingIngredientsTableAdapter.Fill(this.cheeseMakingDataSet.PurshasingIngredients);
            this.ingredientsTableAdapter.Fill(this.cheeseMakingDataSet.Ingredients);
            this.purchasesTableAdapter.Fill(this.cheeseMakingDataSet.Purchases);
            this.supliersTableAdapter.Fill(this.cheeseMakingDataSet.Supliers);
            this.staffTableAdapter.Fill(this.cheeseMakingDataSet.Staff);
            this.staffPositionsTableAdapter.Fill(this.cheeseMakingDataSet.StaffPositions);
            this.jobPositionsTableAdapter.Fill(this.cheeseMakingDataSet.JobPositions);
            this.machineryTableAdapter.Fill(this.cheeseMakingDataSet.Machinery);
            this.processesTableAdapter.Fill(this.cheeseMakingDataSet.Processes);
            this.stagesTableAdapter.Fill(this.cheeseMakingDataSet.Stages);
        }

        private void stagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.stagesBindingNavigator.BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cheeseMakingDataSet);
                tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Something went wrong...\nWould you like to see exception message?",
                    "Error!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);
                if (result == DialogResult.Yes) MessageBox.Show(ex.Message);
                fillAll();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillAll();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    stagesBindingNavigator.BindingSource = stagesBindingSource;
                    break;
                case 1:
                    stagesBindingNavigator.BindingSource = processesBindingSource;
                    fillDataGrid("SELECT Processes.Id, Stages._name, Processes.[_name] FROM dbo.Processes INNER JOIN Stages ON Processes.StageId = Stages.Id", dataGridViewProcesses);
                    dataGridViewProcesses.Columns[0].HeaderText = "Id";
                    dataGridViewProcesses.Columns[1].HeaderText = "Stage";
                    dataGridViewProcesses.Columns[2].HeaderText = "Process";
                    break;
                case 2:
                    stagesBindingNavigator.BindingSource = machineryBindingSource;
                    break;
                case 3:
                    stagesBindingNavigator.BindingSource = jobPositionsBindingSource;
                    break;
                case 4:
                    stagesBindingNavigator.BindingSource = staffBindingSource;
                    break;
                case 5:
                    stagesBindingNavigator.BindingSource = staffPositionsBindingSource;
                    fillDataGrid("SELECT StaffPositions.Id, Staff.FirstName, Staff.MiddleName, Staff.SecondName, JobPositions.[_name] FROM dbo.StaffPositions INNER JOIN Staff ON Staff.Id = StaffPositions.StaffId INNER JOIN JobPositions on JobPositions.Id = StaffPositions.PositionID", dataGridViewSP);
                    dataGridViewSP.Columns[4].HeaderText = "Job position";
                    break;
                case 6:
                    stagesBindingNavigator.BindingSource = supliersBindingSource;
                    break;
                case 7:
                    stagesBindingNavigator.BindingSource = purchasesBindingSource;
                    fillDataGrid("SELECT Purchases.Id, Supliers._name, Purchases.DateOf, Purchases.Cost FROM dbo.Purchases INNER JOIN Supliers ON Supliers.Id = Purchases.SuplierId", dataGridViewPurchases);
                    dataGridViewPurchases.Columns[1].HeaderText = "Suplier";
                    break;
                case 8:
                    stagesBindingNavigator.BindingSource = ingredientsBindingSource;
                    break;
                case 9:
                    stagesBindingNavigator.BindingSource = purshasingIngredientsBindingSource;
                    fillDataGrid("SELECT PurshasingIngredients.Id, Purchases.Id, Ingredients._name, PurshasingIngredients.Volume FROM dbo.PurshasingIngredients INNER JOIN Purchases ON Purchases.Id = PurshasingIngredients.PurchaseId INNER JOIN Ingredients on PurshasingIngredients.IngredientId = Ingredients.Id", dataGridViewPI);
                    dataGridViewPI.Columns[1].HeaderText = "Purchase Id";
                    dataGridViewPI.Columns[2].HeaderText = "Ingredient";
                    fillDataGrid("SELECT Purchases.Id, Supliers._name, Purchases.DateOf, Purchases.Cost FROM dbo.Purchases INNER JOIN Supliers ON Supliers.Id = Purchases.SuplierId", dataGridViewForPIPurchases);
                    dataGridViewForPIPurchases.Columns[1].HeaderText = "Suplier";
                    break;
                case 10:
                    stagesBindingNavigator.BindingSource = sortsBindingSource;
                    break;
                case 11:
                    stagesBindingNavigator.BindingSource = batchFormulaBindingSource;
                    fillDataGrid("SELECT BatchFormula.Id, Sorts._name FROM dbo.BatchFormula INNER JOIN Sorts ON BatchFormula.SortId = Sorts.Id", dataGridViewBF);
                    dataGridViewBF.Columns[1].HeaderText = "Sort";
                    break;
                case 12:
                    stagesBindingNavigator.BindingSource = ingredientsInBatchBindingSource;
                    fillDataGrid("SELECT IngredientsInBatch.Id, BatchFormula.Id, Ingredients._name, IngredientsInBatch.Volume FROM dbo.IngredientsInBatch INNER JOIN BatchFormula ON BatchFormula.Id = IngredientsInBatch.FormulaId INNER JOIN Ingredients on IngredientsInBatch.IngredientId = Ingredients.Id", dataGridViewIIB);
                    dataGridViewIIB.Columns[1].HeaderText = "Formula Id";
                    dataGridViewIIB.Columns[2].HeaderText = "Ingredient";
                    fillDataGrid("SELECT BatchFormula.Id, Sorts._name FROM dbo.BatchFormula INNER JOIN Sorts ON BatchFormula.SortId = Sorts.Id", dataGridViewForIIBBF);
                    dataGridViewForIIBBF.Columns[1].HeaderText = "Sort";
                    break;
                case 13:
                    stagesBindingNavigator.BindingSource = locationsBindingSource;
                    break;
                case 14:
                    stagesBindingNavigator.BindingSource = customersBindingSource;
                    break;
                case 15:
                    stagesBindingNavigator.BindingSource = salesBindingSource;
                    fillDataGrid("SELECT Sales.Id, Customers._name, Locations._name, Sales.Cost FROM dbo.Sales INNER JOIN Customers ON Customers.Id = Sales.CustomerID INNER JOIN Locations on Sales.StorageId = Locations.Id", dataGridViewSales);
                    dataGridViewSales.Columns[1].HeaderText = "Customer";
                    dataGridViewSales.Columns[2].HeaderText = "Storage";
                    break;
                case 16:
                    stagesBindingNavigator.BindingSource = sortsInSalesBindingSource;
                    fillDataGrid("SELECT SortsInSales.Id, Sorts._name, Sales.Id FROM SortsInSales INNER JOIN Sorts on Sorts.Id = SortsInSales.SortId INNER JOIN Sales on Sales.Id = SortsInSales.SaleId", dataGridViewSIS);
                    dataGridViewSIS.Columns[1].HeaderText = "Sort";
                    dataGridViewSIS.Columns[2].HeaderText = "Sale Id";
                    fillDataGrid("SELECT Sales.Id, Customers._name, Locations._name, Sales.Cost FROM dbo.Sales INNER JOIN Customers ON Customers.Id = Sales.CustomerID INNER JOIN Locations on Sales.StorageId = Locations.Id", dataGridViewForSISSales);
                    dataGridViewForSISSales.Columns[1].HeaderText = "Customer";
                    dataGridViewForSISSales.Columns[2].HeaderText = "Storage";
                    break;
                case 17:
                    stagesBindingNavigator.BindingSource = batchesBindingSource;
                    fillDataGrid("SELECT Batches.Id, Sorts._name, Batches.DateOfStart FROM dbo.Batches INNER JOIN Sorts ON Batches.SortId = Sorts.Id", dataGridViewBatches);
                    dataGridViewBatches.Columns[1].HeaderText = "Sort";
                    break;
                case 18:
                    stagesBindingNavigator.BindingSource = activityBindingSource;
                    fillDataGrid("Select Activity.Id, Staff.FirstName, Staff.MiddleName, Staff.SecondName, Processes._name, Batches.Id, Locations._name, Machinery._name, Activity.CompletionDate, Activity.Comment FROM Activity INNER JOIN Staff ON Staff.Id = Activity.StaffId INNER JOIN Processes on Processes.Id = Activity.ProcessId INNER JOIN Batches ON Batches.Id = Activity.BatchId INNER JOIN Locations ON Locations.Id = Activity.LocationId INNER JOIN Machinery ON Machinery.Id = Activity.MachineryId", dataGridViewActivity);
                    dataGridViewActivity.Columns[1].HeaderText = "Staff first name";
                    dataGridViewActivity.Columns[2].HeaderText = "Staff middle name";
                    dataGridViewActivity.Columns[3].HeaderText = "Staff second name";
                    dataGridViewActivity.Columns[4].HeaderText = "Process";
                    dataGridViewActivity.Columns[5].HeaderText = "Batch id";
                    dataGridViewActivity.Columns[6].HeaderText = "Storage";
                    dataGridViewActivity.Columns[7].HeaderText = "Machinery";
                    break;
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginFormTaken.Show();
        }
    }
}
