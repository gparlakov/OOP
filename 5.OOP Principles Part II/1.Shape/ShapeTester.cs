/*Define abstract class Shape with only one abstract method CalculateSurface() and fields width 
 * and height. Define two new classes Triangle and Rectangle that implement the virtual method and r
 * eturn the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define 
 * class Circle and suitable constructor so that at initialization height must be kept equal to width and 
 * implement the CalculateSurface() method. Write a program that tests  the behavior of  the CalculateSurface() 
 * method for different shapes (Circle, Rectangle, Triangle) stored in an array.*/

using System;
using System.Collections.Generic;
using System.Linq;

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
