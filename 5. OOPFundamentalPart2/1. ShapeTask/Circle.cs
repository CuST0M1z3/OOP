using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapeTask
{
    public class Circle : Shape
    {
        public Circle(int height)
            : base(height, height)
        {           
        }

        public override double CalculateSurface()
        {
            Console.WriteLine("Surface of circle is: ");
            return Math.PI * Height * Width;
        }
    }
}
