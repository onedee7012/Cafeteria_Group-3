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

        void LoadListIngredient()
        {
            ingredientList.DataSource = IngredientDAL.Instance.GetListIngredient();
        }
        void AddIngredientBinding()
        {
            tbin.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "name", true, DataSourceUpdateMode.Never));
            tbiid.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbis.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "supplier", true, DataSourceUpdateMode.Never));
            tbiq.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "quantity", true, DataSourceUpdateMode.Never));
            tbiuq.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "usedquantity", true, DataSourceUpdateMode.Never));
            tbilq.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "leftquantity", true, DataSourceUpdateMode.Never));
            tbidi.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "dateIn", true, DataSourceUpdateMode.Never));
            tbido.DataBindings.Add(new Binding("Text", dtgvIngredient.DataSource, "dateOut", true, DataSourceUpdateMode.Never));
        }
        private void btaddi_Click(object sender, EventArgs e)
        {
            string name = tbin.Text;
            int quantity = int.Parse(tbiq.Text);
            int used = int.Parse(tbiuq.Text);
            int left = quantity - used;
            string dateIn = tbidi.Text;
            string dateOut = tbido.Text;
            string supplier = tbis.Text;
            if (IngredientDAL.Instance.InsertIngredient(name, supplier, quantity, used, left, dateIn, dateOut))
            {
                MessageBox.Show("Add ingredient successfully");
                LoadListIngredient();
            }
            else
            {
                MessageBox.Show("Add failed");
            }
        }
        private void btupi_Click(object sender, EventArgs e)
        {
            string name = tbin.Text;
            int quantity = int.Parse(tbiq.Text);
            int used = int.Parse(tbiuq.Text);
            int left = quantity - used;
            string dateIn = tbidi.Text;
            string dateOut = tbido.Text;
            string supplier = tbis.Text;
            int id = Convert.ToInt32(tbiid.Text);
            if (IngredientDAL.Instance.UpdateIngredient(id, name, quantity, used, left, dateIn, dateOut, supplier))
            {
                MessageBox.Show("Update ingredient successfully");
                LoadListIngredient();
            }   
            else
            {
                MessageBox.Show("Update failed");
            }
        }
        private void btdei_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbiid.Text);
            if (IngredientDAL.Instance.DeleteIngredient(id))
            {
                MessageBox.Show("Delete ingredient successfully");
                LoadListIngredient();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }
        private void UpdateLeftQuantity()
        {
            int quantity = 0;
            int used = 0;
            int.TryParse(tbiq.Text, out quantity);
            int.TryParse(tbiuq.Text, out used);
            int left = quantity - used;
            tbilq.Text = left.ToString();
        }
        private void tbiq_TextChanged(object sender, EventArgs e)
        {
            UpdateLeftQuantity();
        }
        private void tbiuq_TextChanged(object sender, EventArgs e)
        {
            UpdateLeftQuantity();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpstart.Value = new DateTime(today.Year, today.Month, 1);
            dtpend.Value = dtpstart.Value.AddMonths(1).AddDays(-1).Date.AddDays(1).AddTicks(-1);
        }
        void LoadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = BillDAL.Instance.GetListBillByDateTime(checkin, checkout);
            if (dtgvBill.Columns["totalPrice"] != null)
            {
                dtgvBill.Columns["totalPrice"].DefaultCellStyle.Format = "#,0.000";
                dtgvBill.Columns["totalPrice"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            }
        }
        private void btload_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpstart.Value, dtpend.Value);
        }
        private void btincome_Click(object sender, EventArgs e)
        {
            float income = 0;
            foreach (DataGridViewRow row in dtgvBill.Rows)
            {
                if (row.Cells["totalPrice"].Value != null)
                {
                    float price = Convert.ToSingle(row.Cells["totalPrice"].Value);
                    income += price;
                }
            }
            CultureInfo ci = new CultureInfo("vi-VN");
            tbtotalin.Text = income.ToString("#,0.000", ci) + " VNĐ";
        }

        private void btfirst_Click(object sender, EventArgs e)
        {
            tbnp.Text = "1";
        }
        private void btpre_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(tbnp.Text);
            if (page > 1)
                page--;
            tbnp.Text = page.ToString();
        }
        private void btnext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(tbnp.Text);
            int sumRecord = BillDAL.Instance.GetNumberBillByDate(dtpstart.Value, dtpend.Value);
            if (page < sumRecord)
                page++;
            tbnp.Text = page.ToString();
        }
        private void btlast_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAL.Instance.GetNumberBillByDate(dtpstart.Value, dtpend.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                lastPage++;
            tbnp.Text = lastPage.ToString();
        }
        private void tbnp_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAL.Instance.GetListBillByDateAndPage(dtpstart.Value, dtpend.Value, Convert.ToInt32(tbnp.Text));
        }
    }
}
