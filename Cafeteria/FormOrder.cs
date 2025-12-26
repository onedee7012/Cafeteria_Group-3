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
        BindingSource membershipList = new BindingSource();
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
        
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
            cbmenu.DataSource = listCategory;
            cbmenu.DisplayMember = "Name";
        }

        void LoadBeverageListByCategoryID(int id)
        {
            List<Beverage> listBeverage = BeverageDAL.Instance.GetBeverageByCategoryID(id);
            cbbeverage.DataSource = listBeverage;
            cbbeverage.DisplayMember = "Name";
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

        void f_InsertBeverage(object sender, EventArgs e)
        {
            LoadBeverageListByCategoryID((cbmenu.SelectedItem as Category).ID);
            if (lvBill.Tag != null)
                ShowBill((lvBill.Tag as Table).ID);
        }

        void f_UpdateBeverage(object sender, EventArgs e)
        {
            LoadBeverageListByCategoryID((cbmenu.SelectedItem as Category).ID);
            if (lvBill.Tag != null)
                ShowBill((lvBill.Tag as Table).ID);
        }

        void f_DeleteBeverage(object sender, EventArgs e)
        {
            LoadBeverageListByCategoryID((cbmenu.SelectedItem as Category).ID);
            if (lvBill.Tag != null)
                ShowBill((lvBill.Tag as Table).ID);
            LoadTable();
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
                    if (idmember != 0)
                    {
                        MembershipDAL.Instance.AddPointToMember(idmember, point);
                    }
                    TableDAL.Instance.UpdateTableStatus(table.ID, "Empty");
                    Bill billInfo = BillDAL.Instance.GetBillByID(idBill);
                    DateTime checkin = billInfo.DateCheckIn ?? DateTime.Now;
                    DateTime checkout = billInfo.DateCheckOut ?? DateTime.Now;

                    FormReceipt f = new FormReceipt();
                    f.LoadReport(idBill, table.Name, checkin, checkout, staff, namemember, totalPrice, discount, finalTotalPrice, point, listBillInfor);
                    f.ShowDialog();
                    ShowBill(table.ID);
                    LoadTable();
                    ResetForm();
                }
            }    
        }

        void LoadMemberPhoneList()
        {
            List<Membership> members = MembershipDAL.Instance.GetMembership();
            cbphone.DataSource = members;
            cbphone.DisplayMember = "Phonenumber";
            cbphone.ValueMember = "Id";
            cbphone.SelectedIndex = -1;
            tbidmb.Text = "0";
            tbmb.Text = "0";
            tbmp.Text = "0";
        }

        private void cbphone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbphone.SelectedIndex == -1 || cbphone.SelectedItem == null)
            {
                tbidmb.Text = "0";
                tbmb.Text = "0";
                tbmp.Text = "0";
            }
        
            else
            {
                Membership selectedMember = cbphone.SelectedItem as Membership;
                if (selectedMember != null)
                {
                    tbidmb.Text = selectedMember.Id.ToString();
                    tbmb.Text = selectedMember.Name;
                    tbmp.Text = selectedMember.Totalpoint.ToString();
                }
            }
        }   
    }
}




