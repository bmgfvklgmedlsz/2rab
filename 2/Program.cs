using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2, 3);


            rect.ShowData();


            double perimeter = rect.Perimetr();
            Console.WriteLine($"Периметр: {perimeter}");
            Console.ReadKey();
        }
    }
}
