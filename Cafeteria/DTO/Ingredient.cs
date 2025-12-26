using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class Ingredient
    {
        public Ingredient(int id, string name, string supplier, int quantity, int usedquantity, int leftquantity, string datein, string dateout)
        {
            this.ID = id;
            this.Name = name;
            this.Supplier = supplier;
            this.Quantity = quantity;
            this.UsedQuantity = usedquantity;
            this.leftQuantity = leftquantity;
            this.DateIn = datein;
            this.DateOut = dateout;
        }
        public Ingredient(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Supplier = row["supplier"].ToString();
            this.Quantity = (int)row["quantity"];
            this.UsedQuantity = (int)row["usedquantity"];
            this.LeftQuantity = (int)row["leftquantity"];
            this.DateIn = row["dateIn"].ToString();
            this.DateOut = row["dateOut"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int usedQuantity;
        public int UsedQuantity
        {
            get { return usedQuantity; }
            set { usedQuantity = value; }
        }

        private int leftQuantity;
        public int LeftQuantity
        {
            get { return leftQuantity; }
            set { leftQuantity = value; }
        }

        private string dateIn;
        public string DateIn
        { 
            get { return dateIn; } 
            set { dateIn = value; } 
        }

        private string dateOut;
        public string DateOut
        {
            get { return dateOut; }
            set { dateOut = value; }
        }

        private string supplier;
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
    }
}
