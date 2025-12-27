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
    public partial class FormMembership : Form
    {
        public FormMembership()
        {
            InitializeComponent();
        }

        void LoadListMembership()
        {
            membershipList.DataSource = MembershipDAL.Instance.GetListMembership();
        }

        void AddMembershipBinding()
        {
            tbfnmb.DataBindings.Add(new Binding("Text", dtgvMembership.DataSource, "name", true, DataSourceUpdateMode.Never));
            tbmbid.DataBindings.Add(new Binding("Text", dtgvMembership.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbmbdob.DataBindings.Add(new Binding("Text", dtgvMembership.DataSource, "dateofbirth", true, DataSourceUpdateMode.Never));
            tbmbpn.DataBindings.Add(new Binding("Text", dtgvMembership.DataSource, "phonenumber", true, DataSourceUpdateMode.Never));
            tbpoint.DataBindings.Add(new Binding("Text", dtgvMembership.DataSource, "totalpoint", true, DataSourceUpdateMode.Never));
        }

        void AddMembership(string name, string dateofbirth, string phonenumber)
        {
            if (MembershipDAL.Instance.AddMembership(name, dateofbirth, phonenumber))
            {
                MessageBox.Show("Add membership successfully");
            }
            else
            {
                MessageBox.Show("Add membership failed");
            }
            LoadListMembership();
        }

        void UpdateMembership(int id, string name, string dateofbirth, string phonenumber)
        {
            if (MembershipDAL.Instance.UpdateMembership(id, name, dateofbirth, phonenumber))
            {
                MessageBox.Show("Update membership successfully");
            }
            else
            {
                MessageBox.Show("Update membership failed");
            }
            LoadListMembership();
        }
        
        void DeleteMembership(int id)
        { 
            if (MembershipDAL.Instance.DeleteMembership(id))
            {
                MessageBox.Show("Delete membership successfully");
            }
            else
            {
                MessageBox.Show("Delete membership failed");
            }
            LoadListMembership();
        }

        private void btaddmb_Click(object sender, EventArgs e)
        {
            string name = tbfnmb.Text;
            string dateofbirth = tbmbdob.Text;
            string phonenumber = tbmbpn.Text;
            AddMembership(name, dateofbirth, phonenumber);
        }

        private void btupmb_Click(object sender, EventArgs e)
        {
            string name = tbfnmb.Text;
            string dateofbirth = tbmbdob.Text;
            string phonenumber = tbmbpn.Text;
            int id = Convert.ToInt32(tbmbid.Text);
            UpdateMembership(id, name, dateofbirth, phonenumber);
        }

        private void btdemb_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbmbid.Text);
            DeleteMembership(id);
        }

    }
}
