

using System;
using System.Linq;

namespace First.Point3D
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        static readonly Point3D center;
        
        
        private static Point3D Center
        {
            get
            {
                return new Point3D(0, 0, 0);
            }
            set
            {
                //this.center = value;
            }
        }

        //public Point3D()
        //{
        //    this.Center = new Point3D { 0, 0, 0 };
        //}

        public Point3D(int x, int y, int z)           
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("Point[x,y,z]: [{0},{1},{2}]",  this.X, this.Y, this.Z);
        }
    }
}
