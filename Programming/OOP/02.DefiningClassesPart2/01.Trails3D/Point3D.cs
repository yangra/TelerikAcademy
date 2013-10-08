using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D();

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Point3D CoordStart
        {
            get
            {
                return pointO;
            }
        }

        public Point3D(int x = 0, int y = 0, int z = 0)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("X: {0}; Y: {1}; Z: {2}", this.X, this.Y, this.Z);
        }
    }
}
