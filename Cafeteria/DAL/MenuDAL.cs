using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return MenuDAL.instance; }
            private set { MenuDAL.instance = value; }
        }

        private MenuDAL() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT dbo.Beverage.name, dbo.BillInfor.quantity, dbo.Beverage.price, dbo.Beverage.price*dbo.BillInfor.quantity AS TotalPrice FROM dbo.BillInfor, dbo.Bill, dbo.Beverage WHERE dbo.BillInfor.idBill = dbo.Bill.id AND dbo.BillInfor.idBeverage = dbo.Beverage.id AND dbo.Bill.status = 0 AND dbo.Bill.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

        public List<Menu> GetListMenuByBill(int billID)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT bvg.name, bi.quantity, bvg.price, (bi.quantity * bvg.price) AS TotalPrice " +
                           "FROM BillInfor bi " +
                           "JOIN Beverage bvg ON bi.idBeverage = bvg.id " +
                           "WHERE bi.idBill = " + billID;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
