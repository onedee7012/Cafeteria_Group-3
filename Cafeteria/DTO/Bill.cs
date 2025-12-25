using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int idTable, string staff, int status, int iDMember, string nameMember, int discount = 0, float totalPrice = 0, float point = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.IdTable = idTable;
            this.Staff = staff;
            this.Status = status;
            this.IDMember = iDMember;
            this.NameMember = nameMember;
            this.Discount = discount;
            this.TotalPrice = totalPrice;
            this.Point = point;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckin"];
            var dateCheckOutTemp = row["DateCheckout"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)row["DateCheckout"];
            this.Staff = row["staff"].ToString();
            this.Status = (int)row["status"];
            this.IDMember = (int)row["idMember"];
            this.NameMember = row["nameMember"].ToString();
            this.Discount = (int)row["discount"];
            this.TotalPrice = row["totalPrice"] == DBNull.Value ? 0 : Convert.ToSingle(row["totalPrice"]);
            this.Point = Convert.ToSingle(row["point"]);
            this.IdTable = (int)row["idTable"];
            if (row.Table.Columns.Contains("name"))
                this.TableName = row["name"].ToString();
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string staff;

        public string Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int iDMember;

        public int IDMember
        {
            get { return iDMember; }
            set { iDMember = value; }
        }     

        private string nameMember;

        public string NameMember
        {
            get { return nameMember; }
            set { nameMember = value; }
        }

        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private float point;

        public float Point
        {
            get { return point; }
            set { point = value; }
        }

        private int idTable;

        public int IdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }

        private string tableName;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

    }
}
