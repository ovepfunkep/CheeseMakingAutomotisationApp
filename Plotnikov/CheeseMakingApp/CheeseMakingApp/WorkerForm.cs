using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CheeseMakingApp.Utilities;

namespace CheeseMakingApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm(LoginForm loginFormGiven)
        {
            InitializeComponent();
            loginFormTaken = loginFormGiven;
        }

        private LoginForm loginFormTaken;

        private void fillAll()
        {
            this.machineryTableAdapter.Fill(this.cheeseMakingDataSet.Machinery);
            this.locationsTableAdapter.Fill(this.cheeseMakingDataSet.Locations);
            this.batchesTableAdapter.Fill(this.cheeseMakingDataSet.Batches);
            this.processesTableAdapter.Fill(this.cheeseMakingDataSet.Processes);
            this.staffTableAdapter.Fill(this.cheeseMakingDataSet.Staff);
            this.activityTableAdapter.Fill(this.cheeseMakingDataSet.Activity);
        }

        private void WorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginFormTaken.Show();
        }

        private void activityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.activityBindingNavigator.BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cheeseMakingDataSet);
                //tabControl1_SelectedIndexChanged(sender, e);
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

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            fillAll();
        }

        private void panelActivity_MouseEnter(object sender, EventArgs e)
        {
            activityBindingNavigator.BindingSource = activityBindingSource;
        }

        private void panelBatches_MouseEnter(object sender, EventArgs e)
        {
            activityBindingNavigator.BindingSource = batchesBindingSource;
        }

        private void comboBoxBatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelProcess.Text = checkNextStep(comboBoxBatches.SelectedIndex);
        }

        private void buttonOpenTableActivity_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            fillDataGrid("Select Activity.Id, Staff.FirstName, Staff.MiddleName, Staff.SecondName, Processes._name, Batches.Id, Locations._name, Machinery._name, Activity.CompletionDate, Activity.Comment FROM Activity INNER JOIN Staff ON Staff.Id = Activity.StaffId INNER JOIN Processes on Processes.Id = Activity.ProcessId INNER JOIN Batches ON Batches.Id = Activity.BatchId INNER JOIN Locations ON Locations.Id = Activity.LocationId INNER JOIN Machinery ON Machinery.Id = Activity.MachineryId", tableForm.dataGridView1);
            tableForm.dataGridView1.Columns[1].HeaderText = "Staff first name";
            tableForm.dataGridView1.Columns[2].HeaderText = "Staff middle name";
            tableForm.dataGridView1.Columns[3].HeaderText = "Staff second name";
            tableForm.dataGridView1.Columns[4].HeaderText = "Process";
            tableForm.dataGridView1.Columns[5].HeaderText = "Batch id";
            tableForm.dataGridView1.Columns[6].HeaderText = "Storage";
            tableForm.dataGridView1.Columns[7].HeaderText = "Machinery";
            tableForm.Text = "Activity";
            tableForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(); 
            fillDataGrid("SELECT Batches.Id, Sorts._name, Batches.DateOfStart FROM dbo.Batches INNER JOIN Sorts ON Batches.SortId = Sorts.Id", tableForm.dataGridView1);
            tableForm.dataGridView1.Columns[1].HeaderText = "Sort";
            tableForm.Text = "Batches";
            tableForm.Show();
        }
    }
}
