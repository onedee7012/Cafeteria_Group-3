using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class Membership
    {
        public Membership(int id, string name, string dateofbirth, string phonenumber, float totalpoint)
        {
            this.Name = name;
            this.Phonenumber = phonenumber;
            this.DateofBirth = dateofbirth;
            this.Id = id;
            this.Totalpoint = totalpoint;
        }
        public Membership(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Phonenumber = row["phonenumber"].ToString();
            this.DateofBirth = row["dateofbirth"].ToString();
            this.Id = (int)row["id"];
            this.Totalpoint = Convert.ToSingle(row["totalpoint"]);
        }

        private string phonenumber;
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string dateofBirth;
        public string DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private float totalpoint;
        public float Totalpoint
        {
            get { return totalpoint; }
            set { totalpoint = value; }
        }
    }
}
