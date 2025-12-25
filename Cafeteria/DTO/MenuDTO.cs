using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class Menu
    {
        public Menu(string beverageName, int count, int price, int totalPrice = 0)
        {
            this.BeverageName = beverageName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.BeverageName = row["name"].ToString();
            this.Count = (int)row["quantity"];
            this.Price = (int)row["price"];
            this.TotalPrice = (int)row["totalPrice"];
        }

        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private string beverageName;

        public string BeverageName
        {
            get { return beverageName; }
            set { beverageName = value; }
        }
    }
}
