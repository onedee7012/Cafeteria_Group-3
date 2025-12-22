using Cafeteria.DAL;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName, passWord);
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string userName = tbuser.Text;
            string passWord = tbpass.Text;
            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAL.Instance.GetAccountByUserName(userName);
                FormHome f = new FormHome(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            tbpass.UseSystemPasswordChar = !chbshowpass.Checked;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
       
    }
}
