using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Circle : Shape,IDrawable
    {
      public  double Radius { get; }

        

        public Circle(double radius)
        {
            Radius = radius;        //this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 1 * Math.PI * Radius * Radius;
            
        }
        public void Draw()
        {
            Console.WriteLine("Circle:");
            Console.WriteLine("Radius:{Radius}");
            Console.WriteLine("Area:{CalculateArea()}");
            Console.WriteLine("Perimeter:{CalculatePerimeter()}");
        }
    }
}
