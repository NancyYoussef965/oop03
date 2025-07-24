using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oop03.Program;

namespace oop03
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public HiringDate HireDate { get; set; }

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


        public employee(int id, string name, char gender, SecurityLevel security, HiringDate hiringDate, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;   
            Security = security;
            HireDate = hiringDate;
            Salary = salary;         
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {Gender}\n" +
                   $"Security Level: {Security}\n" +
                   $"Hire Date: {HireDate}\n" +
                   $"Salary: {string.Format("{0:C}", Salary)}";
        }
    }
}