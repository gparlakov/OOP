

using System;
using System.Linq;

namespace ThreeDimensionalSpace
{
    public struct Point3D
    {
        private string name;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.name = String.Format("[{0},{1},{2}]", this.X, this.Y, this.Z);
                }
                else
                {
                    this.name = value;
                }
            }
        }
        private static readonly Point3D center = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z,string name=null)    
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Name = name;
        }

        public static Point3D Center
        {
            get
            {
                return center;
            }
        }

        public override string ToString()
        {
            return String.Format("Point[{3}]: [{0},{1},{2}]",  this.X, this.Y, this.Z,this.Name);
        }
    }
}
