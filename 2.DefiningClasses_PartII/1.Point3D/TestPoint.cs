/*1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.  * Implement the ToString() to enable printing a 3D point.2.Add a private static read-only field to hold the start of the coordinate  * system – the point O{0, 0, 0}. Add a static property to return the point O.3.Write a static class with a static method to calculate the distance between * two points in the 3D space.4.Create a class Path to hold a sequence of points in the 3D space. Create a 
 * static class PathStorage with static methods to save and load paths from a
 * text file. Use a file format of your choice.
*/
using System;

namespace ThreeDimensionalSpace
{
    class TestPoint
    {
        static void Main()
        {
            Point3D point1 = new Point3D(-1, -1, 1,"K");
            Point3D point2 = new Point3D(-2, -2, -2, "M");           
            Console.WriteLine("Center {0}\n{1}\n{2}\nDistance between point {4} and {5}:\t{3}", Point3D.Center, point1, point2, 
                DistanceCalculator3D.CalculateDistance3D(point1, point2),point1.Name,point2.Name);          
        }
    }
}
