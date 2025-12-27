using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAL
{
    public class BeverageDAL
    {
        private static BeverageDAL instance;

        public static BeverageDAL Instance
        {
            get { if (instance == null) instance = new BeverageDAL(); return BeverageDAL.instance; }
            private set { BeverageDAL.instance = value; }
        }

        private BeverageDAL() { }

        public List<Beverage> GetBeverageByCategoryID(int id)
        {
            List<Beverage> list = new List<Beverage>();
            string query = "SELECT * FROM Beverage WHERE idMenu = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Beverage beverage = new Beverage(item);
                list.Add(beverage);
            }

            return list;
        }

        public List<Beverage> GetListBeverage()
        {
            List<Beverage> list = new List<Beverage>();
            string query = "SELECT * FROM Beverage";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Beverage beverage = new Beverage(item);
                list.Add(beverage);
            }

            return list;
        }

        public static bool InsertBeverage(string name, int idcategory, float price, string image)
        {
            string query = string.Format("INSERT dbo.Beverage ( name, idMenu, price, image ) VALUES ( N'{0}', {1}, {2}, N'{3}' )", name, idcategory, price, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public static bool UpdateBeverage(int idbeverage, string name, int idcategory, float price, string image)
        {
            string query = string.Format("UPDATE dbo.Beverage SET name = N'{0}', idMenu = {1}, price = {2}, image = N'{3}' WHERE id = {4}", name, idcategory, price, image, idbeverage);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBeverage(int idbeverage)
        {
            string query = string.Format("DELETE Beverage WHERE id = {0}", idbeverage);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}