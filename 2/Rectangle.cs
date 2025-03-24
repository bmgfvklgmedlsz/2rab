using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Rectangle
    {

        private double height;
        private double width;


        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Высота должна быть положительной.");
                    height = 1;
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина должна быть положительной.");
                    width = 1;
                }
                else
                {
                    width = value;
                }
            }
        }



        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public Rectangle() : this(1, 1) { }


        public void ShowData()
        {
            Console.WriteLine($"Высота: {Height}, Ширина: {Width}");
        }

        public double Perimetr()
        {
            return 2 * (Height + Width);
        }
    }
}
