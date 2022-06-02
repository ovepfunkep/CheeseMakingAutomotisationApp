using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CheeseMakingApp
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "columnButtons" && e.RowIndex != -1)
                if (this.Text == "Sales")
                {
                    SqlCommand command = new SqlCommand("Select Sorts._name from Sorts inner join SortsInSales on Sorts.Id = SortId where SaleId = @SaleId");
                    command.Parameters.AddWithValue("SaleId", dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    object[][] data = Utilities.getData(command);
                    object[] sorts = data[0];
                    MessageBox.Show(String.Join("",sorts));
                }
                else
                {
                    SqlCommand command = new SqlCommand("Select Ingredients._name, Volume from PurshasingIngredients inner join Ingredients on Ingredients.Id = IngredientId inner join Purchases on Purchases.Id = PurchaseId where PurchaseId = @PurchaseId");
                    command.Parameters.AddWithValue("PurchaseId", dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    object[][] data = Utilities.getData(command);
                    string sOut = "";
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        sOut += $"{String.Concat($"{data[i][0].ToString()} - ", data[i][1].ToString())}\n";
                    }
                    MessageBox.Show(sOut);
                }
        }
    }
}
