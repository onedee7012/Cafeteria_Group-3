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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        
        private void tbdiscount_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(tbtotal.Text, out float total) && int.TryParse(tbdiscount.Text, out int discount))
            {
                float finalPrice = total - (total * discount / 100f);
                tbprice.Text = finalPrice.ToString("0.##");
            }
            else
            {
                tbprice.Text = tbtotal.Text;
            }
        }

        private void tbamount_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(tbamount.Text, out float amount) && float.TryParse(tbprice.Text, out float price))
            {
                float change = amount - price;
                tbchange.Text = change.ToString("0.##");
            }
            else
            {
                tbchange.Text = "";
            }
        }
    
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAL.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                case "Empty":
                    btn.BackColor = Color.Teal;
                    break;
                default:
                    btn.BackColor = Color.Chocolate;
                    break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<Menu> listBillInfor = MenuDAL.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfor)
            {
                ListViewItem lvItem = new ListViewItem(item.BeverageName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString("N0"));
                lvItem.SubItems.Add(item.TotalPrice.ToString("N0"));
                totalPrice += item.TotalPrice;
                lvBill.Items.Add(lvItem);
            }
            tbtotal.Text = totalPrice.ToString("N0");
        }

        private void btaddb_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Please choose the table");
                return;
            }
            int idBill = BillDAL.Instance.GetUncheckedBillIDByTableID(table.ID);
            int beverageID = (cbbeverage.SelectedItem as Beverage).ID;
            int count = (int)numquantity.Value;

            if (idBill == -1)
            {
                BillDAL.Instance.InsertBill(table.ID);
                BillInforDAL.Instance.InsertBillInfor(BillDAL.Instance.GetMaxIDBill(), beverageID, count);
                TableDAL.Instance.UpdateTableStatus(table.ID, "Full");
            }
            else
            {
                BillInforDAL.Instance.InsertBillInfor(idBill, beverageID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btpay_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idBill = BillDAL.Instance.GetUncheckedBillIDByTableID(table.ID);
            int.TryParse(tbdiscount.Text, out int discount);
            int.TryParse(tbidmb.Text, out int idmember);
            string namemember = tbmb.Text.Trim();
            string staff = tbstaff.Text.Trim();

            if (!float.TryParse(tbtotal.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out float totalPrice)) return;
            float finalTotalPrice = totalPrice - (totalPrice * discount / 100f);
            float point = finalTotalPrice / 10;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Are you sure to pay for the {0}?", table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    List<Menu> listBillInfor = MenuDAL.Instance.GetListMenuByTable(table.ID);
                    BillDAL.Instance.Checkout(idBill, discount, idmember, namemember, staff, (float)finalTotalPrice, (float)point);             
                    TableDAL.Instance.UpdateTableStatus(table.ID, "Empty");
                    Bill billInfo = BillDAL.Instance.GetBillByID(idBill);
                    DateTime checkin = billInfo.DateCheckIn ?? DateTime.Now;
                    DateTime checkout = billInfo.DateCheckOut ?? DateTime.Now;
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }
    }
}




