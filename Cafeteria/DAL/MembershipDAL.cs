using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAL
{
    public class MembershipDAL
    {
        private static MembershipDAL instance;
        public static MembershipDAL Instance
        {
            get { if (instance == null) instance = new MembershipDAL(); return instance; }
            private set { instance = value; }
        }

        private MembershipDAL() { }
        public DataTable GetListMembership()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id, name, dateofbirth, phonenumber, FORMAT(totalpoint, 'N2') AS totalpoint FROM dbo.Membership");
        }
        public List<Membership> GetMembership()
        {
            List<Membership> list = new List<Membership>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Membership");

            foreach (DataRow row in data.Rows)
            {
                list.Add(new Membership(row));
            }
            return list;
        }

        public bool UpdateMembership(int id, string name, string dateofbirth, string phonenumber)
        {
            string query = string.Format("UPDATE dbo.Membership SET name = N'{0}', dateofbirth = N'{1}', phonenumber = N'{2}' WHERE id = {3}", name, dateofbirth, phonenumber, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool AddPointToMember(int id, float point)
        {
            string query = string.Format("UPDATE Membership SET totalpoint = totalpoint + {0} WHERE id = {1}", point.ToString("0.##"), id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool AddMembership(string name, string dateofbirth, string phonenumber)
        {
            string query = string.Format("INSERT dbo.Membership ( name, dateofbirth, phonenumber ) VALUES ( N'{0}', N'{1}', N'{2}' )", name, dateofbirth, phonenumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteMembership(int id)
        {
            string query = string.Format("DELETE Membership WHERE id = N'{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
