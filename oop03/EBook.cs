using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    internal class EBook : Book
    {

        public double FileSize { get; set; }

        public EBook(string title, string author, string isbn, double fileSize): base(title, author, isbn) 
        {

            FileSize= fileSize;


        }
        public override void DisplayInfo()

        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");

        }


    }
}
