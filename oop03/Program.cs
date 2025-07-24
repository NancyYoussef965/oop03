using System;

namespace oop03
{
    internal class Program
    {

        #region Q1
        //public enum SecurityLevel
        //{
        //    Guest,
        //    Developer,
        //    Secretary,
        //    DBA
        //}
        #endregion
        static void Main(string[] args)
        {

            #region Q1
            employee emp = new employee()
            {
                Id = 1,
                Name = "Nana Youssef",
                Gender = 'F',
                Security = SecurityLevel.Developer,
                Salary = 15000,
                HireDate = new HiringDate(24, 7, 2025)
            };

            Console.WriteLine(emp);



            #endregion

            #region Q2
        


            #endregion

            #region
            #endregion

            #region
            #endregion
        }
    }
}