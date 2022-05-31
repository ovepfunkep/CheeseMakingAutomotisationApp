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
using System.Data.SqlClient;

namespace CheeseMakingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (checkUser(textBoxLogin.Text, textBoxPassword.Text))
            {
                if (isUserAdmin(textBoxLogin.Text))
                {
                    AdminForm adminForm = new AdminForm(this);
                    adminForm.Show();
                    this.Hide();
                }
                else if (isUserAccountant(textBoxLogin.Text))
                {
                    AccountantForm accountantForm = new AccountantForm(this);
                    accountantForm.Show();
                    this.Hide();
                }
                else
                {
                    WorkerForm workerForm = new WorkerForm(this);
                    workerForm.Show();
                    this.Hide();
                }
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "TyabinIA";
            textBoxPassword.Text = "123";
            buttonEnter_Click(sender,e);
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "BaturinOO";
            textBoxPassword.Text = "123";
            buttonEnter_Click(sender, e);
        }

        private void buttonAccountant_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "TyabinaEY";
            textBoxPassword.Text = "123";
            buttonEnter_Click(sender, e);
        }
    }
}
