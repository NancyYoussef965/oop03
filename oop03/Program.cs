using System;

namespace oop03
{
    internal class Program
    {

      
        static void Main(string[] args)
        {

            #region Q1
            //employee emp = new employee()
            //{
            //    Id = 1,
            //    Name = "Nana Youssef",
            //    Gender = 'F',
            //    Security = SecurityLevel.Developer,
            //    Salary = 15000,
            //    HireDate = new HiringDate(24, 7, 2025)
            //};

            //Console.WriteLine(emp);



            #endregion

            #region Q3

            //employee[] EmpArr = new employee[3];

            //EmpArr[0] = new employee(1, "Ali", 'M', SecurityLevel.DBA, new HiringDate(1, 1, 2020), 20000);
            //EmpArr[1] = new employee(2, "Sara", 'F', SecurityLevel.Guest, new HiringDate(5, 6, 2022), 8000);
            //EmpArr[2] = new employee(3, "Mohamed", 'M', SecurityLevel.Developer, new HiringDate(10, 3, 2021), 25000);

            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine("-------------------------");
            //}

            #endregion

            #region Q5
            EBook ebook = new EBook("C# Programming", "John Doe", "123-456789", 5.4);
            PrintedBook printedBook = new PrintedBook("OOP Concepts", "Jane Smith", "987-654321", 350);

            Console.WriteLine("EBook Info:");
            ebook.DisplayInfo();

            Console.WriteLine("\nPrinted Book Info:");
            printedBook.DisplayInfo();
            #endregion

            #region
            #endregion
        }
    }
}