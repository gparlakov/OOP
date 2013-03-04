using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSpace
{
    class ShapeTester
    {
        static void Main()
        {   
            ICollection<Shape> shapes = new Shape[4]
                {   
                    new Triangle(5, 6),
                    new Rectangle(5, 6),
                    new Rectangle(2,2),
                    new Circle(4)
                };
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0,-10} has surface of {1:f2,10} cm*cm",shape.GetType().Name,shape.CalculateSurface());
            }
        }
    }
}
