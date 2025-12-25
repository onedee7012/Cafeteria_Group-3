using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class Beverage
    {
        public Beverage(int id, string name, int categoryID, int price, string image)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
            this.Image = image;
        }
        public Beverage(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idMenu"];
            this.Price = (int)row["price"];
            this.Image = row["image"].ToString();
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
