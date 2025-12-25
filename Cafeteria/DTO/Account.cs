using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class Account
    {
        public Account(string userName, string fullName, string dateofbirth, int type, string passWord, string image)
        {
            this.UserName = userName;            
            this.FullName = fullName;
            this.DateofBirth = dateofbirth;
            this.Type = type;
            this.PassWord = passWord;
            this.Image = image;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.FullName = row["FullName"].ToString();
            this.DateofBirth = row["DateofBirth"].ToString();
            this.Type = (int)row["Type"];
            this.PassWord = row["PassWord"].ToString();
            this.Image = row["Image"].ToString();
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private string dateofBirth;
        public string DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }

        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string passWord;
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
