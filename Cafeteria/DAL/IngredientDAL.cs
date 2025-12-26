using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAL
{
    public class IngredientDAL
    {
        private static IngredientDAL instance;

        public static IngredientDAL Instance
        {
            get { if (instance == null) instance = new IngredientDAL(); return IngredientDAL.instance; }
            private set { IngredientDAL.instance = value; }
        }
        private IngredientDAL() { }

        public List<Ingredient> GetListIngredient()
        {
            List<Ingredient> list = new List<Ingredient>();
            string query = "SELECT * FROM Ingredient";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ingredient ingredient = new Ingredient(item);
                list.Add(ingredient);
            }
            return list;
        }
        public bool InsertIngredient(string name, string supplier, int quantity, int used, int left, string dateIn, string dateOut)
        {
            string query = string.Format("INSERT dbo.Ingredient ( name, supplier, quantity, usedquantity, leftquantity, dateIn, dateOut ) VALUES ( N'{0}', N'{1}', {2}, {3}, {4}, N'{5}', N'{6}' )", name, supplier, quantity, used, left, dateIn, dateOut);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateIngredient(int id, string name, int quantity, int used, int left, string dateIn, string dateOut, string supplier)
        {
            string query = string.Format("UPDATE dbo.Ingredient SET name = N'{0}', quantity = {1}, usedquantity = {2}, leftquantity = {3}, dateIn = N'{4}', dateOut = N'{5}', supplier = N'{6}' WHERE id = {7}", name, quantity, used, left, dateIn, dateOut, supplier, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteIngredient(int idingredient)
        {
            string query = string.Format("DELETE Ingredient WHERE id = {0}", idingredient);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
