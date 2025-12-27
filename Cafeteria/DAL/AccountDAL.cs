using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        private AccountDAL() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
                public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT FullName, DateofBirth, UserName, PassWord, Type, Image FROM dbo.Account");
        }
        public bool AddAccount(string username, string fullname, string password, string dateofbirth, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, FullName, PassWord, DateofBirth, Type ) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}', {4} )", username, fullname, password, dateofbirth, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string username, string fullname, string dateofbirth, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET FullName = N'{1}', DateofBirth = N'{2}', Type = {3} WHERE UserName = N'{0}'", username, fullname, dateofbirth, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Account> GetAccountList()
        {
            List<Account> list = new List<Account>();
            string query = "SELECT * FROM Account";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                list.Add(acc);
            }

            return list;
        }

        public static bool EditAccount(string userName, string fullName, string passWord, string newpassWord, string image)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @username , @password , @fullname , @newpassword , @image", new object[] { userName, fullName, passWord, newpassWord, image });
            return result > 0;
        }
    }
}
        
        