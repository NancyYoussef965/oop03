using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oop03.Program;

namespace oop03
{
    internal class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public DateTime HireDate { get; set; }

        private char gender;
        private decimal _salary;

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }


        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    throw new ArgumentException("Salary must be non-negative");
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Name : {Name}\n" +
                   $"Gender: {Gender}\n" +
                   $"Security: {Security}\n" +
                   $"Hire Date: {HireDate.ToShortDateString()}\n" +
                   $"Salary: {string.Format("{0:C}", Salary)}";
        }
    }

 
}
