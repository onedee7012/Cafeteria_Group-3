using Cafeteria.DAL;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Menu = Cafeteria.DTO.Menu;

namespace Cafeteria
{
    public partial class FormOrder : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public FormOrder(Account acc)
        {
            InitializeComponent();
            
            this.LoginAccount = acc;
            ShowStaffName();
            LoadTable();
            LoadCategory();
           
        }

        private void ShowStaffName()
        {
            tbstaff.Text = loginAccount.FullName;
        }

       void btn_Click(object sender, EventArgs e)
       {
           int tableID = ((sender as Button).Tag as Table).ID;
           lvBill.Tag = (sender as Button).Tag;
           ShowBill(tableID);
       }

       private void btlogout_Click(object sender, EventArgs e)
       {
           this.Close();
       }

        private void cbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadBeverageListByCategoryID(id);
        }
        
    }
}

