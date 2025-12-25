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
    public partial class FormHome : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public FormHome(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadUserInfo();
        }
        
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Visible = type == 1;
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder f = new FormOrder(this.loginAccount);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.loginAccount = LoginAccount;
            f.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccount f = new FormAccount(LoginAccount);
            f.ShowDialog();
        }

        void LoadUserInfo()
        {
            tbfn_home.Text = loginAccount.FullName;
            tbun_home.Text = loginAccount.UserName;
            tbr_home.Text = loginAccount.Type == 1 ? "Admin" : "Staff";

            if (!string.IsNullOrEmpty(loginAccount.Image) && File.Exists(loginAccount.Image))
            {
                ptbava.Image = Image.FromFile(loginAccount.Image);
            }
            else
            {
                ptbava.Image = null;
            }
        }
    }
}
