using System;

namespace oop03
{
    internal class Program
    {

        #region Q1
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }
        #endregion
        static void Main(string[] args)
        {

            #region Q1
            employee emp = new employee()
            {
                Id = 101,
                Name = "nancy youssef",
                Gender = 'F',
                Security = SecurityLevel.Developer,
                Salary = 12000.50m,
                HireDate = new DateTime(2021, 5, 15)



            };
            Console.WriteLine(emp.ToString());



            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion
        }
    }
}