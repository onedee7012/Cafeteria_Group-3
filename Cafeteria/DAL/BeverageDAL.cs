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
    }
}