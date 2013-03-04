using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSpace
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)            
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            return width * height / 2; 
        }
    }
}
