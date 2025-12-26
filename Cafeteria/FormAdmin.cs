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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void LoadStaffToComboBox()
        {
            List<Account> list = AccountDAL.Instance.GetAccountList();
            cbfnstaff.Items.Clear();
            foreach (Account acc in list)
            {
                cbfnstaff.Items.Add(acc.FullName);
            }
        }

        private void btloadns_Click(object sender, EventArgs e)
        {
            string selectedStaff = cbfnstaff.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStaff))
            {
                MessageBox.Show("Please choose the staff");
                return;
            }
            float total = 0;
            foreach (DataGridViewRow row in dtgvBill.Rows)
            {
                if (row.Cells["staff"].Value != null && row.Cells["staff"].Value.ToString() == selectedStaff)
                {
                    if (float.TryParse(row.Cells["totalPrice"].Value.ToString(), out float price))
                    {
                        total += price;
                    }
                }
            }
            CultureInfo ci = new CultureInfo("vi-VN");
            tbins.Text = total.ToString("#,0.000", ci) + " VNĐ";
        }
    }
}
