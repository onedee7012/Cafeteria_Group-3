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

        
        public bool UpdateMembership(int id, string name, string dateofbirth, string phonenumber)
        {
            string query = string.Format("UPDATE dbo.Membership SET name = N'{0}', dateofbirth = N'{1}', phonenumber = N'{2}' WHERE id = {3}", name, dateofbirth, phonenumber, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        
    }
}
