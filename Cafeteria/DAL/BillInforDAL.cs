using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAL
{
    public class BillInforDAL
    {
        private static BillInforDAL instance;

        public static BillInforDAL Instance
        {
            get { if (instance == null) instance = new BillInforDAL(); return BillInforDAL.instance; }
            private set { BillInforDAL.instance = value; }
        }

        private BillInforDAL() { }

        public List<BillInfor> GetListBillInfor(int id)
        {
            List<BillInfor> listBillInfor = new List<BillInfor>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfor WHERE idBill = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfor infor = new BillInfor(item);
                listBillInfor.Add(infor);
            }
            return listBillInfor;
        }

        public void InsertBillInfor(int idBill, int idBeverage, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillInfor @idBill , @idBeverage , @count", new object[] { idBill, idBeverage, count });
        }
    }
}
