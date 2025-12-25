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
    }
}

