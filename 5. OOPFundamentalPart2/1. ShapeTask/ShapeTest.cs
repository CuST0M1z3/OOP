using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapeTask
{
    public class ShapeTest
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[] 
            {
                new Rectangle(5, 4),
                new Triangle(3, 3),
                new Circle(5)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }

        }
    }
}
