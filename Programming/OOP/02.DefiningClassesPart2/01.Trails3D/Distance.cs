using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            int dX = p1.X - p2.X;
            int dY = p1.Y - p2.Y;
            int dZ = p1.Z - p2.Z;
            double distance = Math.Sqrt(dX * dX + dY * dY + dZ * dZ);
            return distance;
        }
    }
}
