using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2uzd
{
    class concstr
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }
        public int Salary { get; set; }
        public int WorkYear { get; set; }

        public concstr(string UserID, string Name, string Surname, DateTime Dob, int Salary, int WorkYear)
        {
            this.UserID = UserID;
            this.Name = Name;
            this.Surname = Surname;
            this.Dob = Dob;
            this.Salary = Salary;
            this.WorkYear = WorkYear;
        }
    }
}
