using Cafeteria.DAL;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafeteria
{
    public partial class FormAccount : Form
    {
        private Account loginAccount;
        private string image = "";
        private string imageFolder = Path.Combine(Application.StartupPath, "images");

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public FormAccount(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            tbun.Text = LoginAccount.UserName;
            tbfn.Text = LoginAccount.FullName;
            tbrole.Text = Convert.ToString(LoginAccount.Type);
        }

        void UpdateAccountInfor()
        {
            string fullName = tbfn.Text;
            string passWord = tbpw.Text;
            string newpassWord = tbnp.Text;
            string enterpassWord = tbcp.Text;
            string userName = tbun.Text;
            int type = int.Parse(tbrole.Text);

            bool success = AccountDAL.EditAccount(userName, fullName, passWord, newpassWord, image);

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(passWord))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }
            if (!newpassWord.Equals(enterpassWord))
            {
                MessageBox.Show("Please enter the right new password !");
            }
            else
            {
                if (success)          
                    MessageBox.Show("Update successfully");              
                else
                    MessageBox.Show("Update failed. Please check your password.");
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfor();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btimport_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(sourcePath);
                string ext = Path.GetExtension(sourcePath);
                string uniqueFileName = $"{fileName}_{DateTime.Now.Ticks}{ext}";
                string destPath = Path.Combine(imageFolder, uniqueFileName);
                try
                {
                    File.Copy(sourcePath, destPath, false);
                    using (FileStream fs = new FileStream(destPath, FileMode.Open, FileAccess.Read))
                    {
                        ptbacc.Image = Image.FromStream(fs);
                    }
                    image = destPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error copying image: " + ex.Message);
                }
            }
        }

        private void chbpw_CheckedChanged(object sender, EventArgs e)
        {
            tbpw.UseSystemPasswordChar = !chbpw.Checked;
        }

        private void chbnp_CheckedChanged(object sender, EventArgs e)
        {
            tbnp.UseSystemPasswordChar = !chbnp.Checked;
        }

        private void chbcp_CheckedChanged(object sender, EventArgs e)
        {
            tbcp.UseSystemPasswordChar = !chbcp.Checked;
        }
    }
}
