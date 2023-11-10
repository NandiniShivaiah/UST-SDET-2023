using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Rectangle : Shape,IDrawable


    {

        public double Length { get;  }

        public double Width { get; }   

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 1*(Length+Width);
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("Length:{Length}");
            Console.WriteLine("Width:{Width}");


            Console.WriteLine("Area:{CalculateArea()}");
            Console.WriteLine("Perimeter:{CalculatePerimeter()}");
        }
    }
}
