using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class BillInfor
    {
        public BillInfor(int id, int billID, int beverageID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.BeverageID = beverageID;
            this.Count = count;
        }

        public BillInfor(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.BeverageID = (int)row["idBeverage"];
            this.Count = (int)row["quantity"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int beverageID;

        public int BeverageID
        {
            get { return beverageID; }
            set { beverageID = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
