using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Cafeteria.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set { BillDAL.instance = value; }
        }

        private BillDAL() { }
        public int GetUncheckedBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void Checkout(int id, int discount, int idmember, string namemember, string staff, float totalPrice, float point)
        {
            string query = "UPDATE dbo.Bill SET DateCheckout = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + ", point = " + point + ", idMember = " + idmember + ", nameMember = N'" + namemember + "' " + ", staff = N'" + staff + "' " + "WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        public DataTable GetListBillByDateTime(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDateTime @checkin , @checkout", new object[] { checkin, checkout });
        }

        public DataTable GetListBillByDateAndPage(DateTime checkin, DateTime checkout, int pagenumber)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDateAndPage @checkin , @checkout , @page", new object[] { checkin, checkout, pagenumber });
        }

        public int GetNumberBillByDate(DateTime checkin, DateTime checkout)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumberBillByDate @checkin , @checkout", new object[] { checkin, checkout });
        }

        public DataTable GetListBill(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBill @checkin , @checkout", new object[] { checkin, checkout });
        }

        public Bill GetBillByID(int id)
        {
            string query = "SELECT dbo.Bill.*, dbo.CoffeeTable.name FROM dbo.Bill JOIN dbo.CoffeeTable ON dbo.Bill.idTable = dbo.CoffeeTable.id WHERE dbo.Bill.id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new Bill(data.Rows[0]);
            }
            return null;
        }
    }
}
