using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CheeseMakingApp
{
    class Utilities
    {
        public static string connectionString = @"Data Source=Dbsrv\sql2021;Initial Catalog=CheeseMaking;Integrated Security=True";
        
        public static bool checkUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select Login from Accounts where Login = @Username and Password = @Password";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Username", username);
                command.Parameters.AddWithValue("Password", password);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
        }

        public static bool isUserAdmin(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select JobPositions._name from Accounts inner join StaffAccounts on Accounts.Id = StaffAccounts.AccountId inner join Staff on StaffAccounts.StaffId = Staff.Id inner join StaffPositions on Staff.Id = StaffPositions.StaffId inner join JobPositions on JobPositions.Id = StaffPositions.PositionId where Accounts.Login = @username";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("username", username);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader["_name"].ToString() == "Director") return true;
                else return false;
            }
        }

        public static bool isUserAccountant(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select JobPositions._name from Accounts inner join StaffAccounts on Accounts.Id = StaffAccounts.AccountId inner join Staff on StaffAccounts.StaffId = Staff.Id inner join StaffPositions on Staff.Id = StaffPositions.StaffId inner join JobPositions on JobPositions.Id = StaffPositions.PositionId where Accounts.Login = @username";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("username", username);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader["_name"].ToString() == "Accountent") return true;
                else return false;
            }
        }

        public static DataSet fillDataGrid(string query, DataGridView dataGrid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGrid.DataSource = dataSet.Tables[0];
                return dataSet;
            }
        }

        public static string checkNextStep(int batchId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select Id,_name from Processes";
                connection.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(query, connection);
                DataSet dataset = new DataSet();
                dataset.Tables.Add();
                adapter1.Fill(dataset.Tables[0]);
                query = "Select Processes.Id from Processes inner join Activity on Activity.ProcessId = Processes.Id where Activity.BatchId = @batchId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("batchId", batchId);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                dataset.Tables.Add();
                adapter2.Fill(dataset.Tables[1]);
                return dataset.Tables[0].Rows[dataset.Tables[1].Rows.Count][1].ToString();
            }
        }

        public static object[][] getData(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                object[][] array = new object[dataSet.Tables[0].Rows.Count][];
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    array[dataSet.Tables[0].Rows.IndexOf(row)] = new object[row.ItemArray.Length];
                    row.ItemArray.CopyTo(array[dataSet.Tables[0].Rows.IndexOf(row)],0);
                }
                return array;
            }
        }
    }
}
