using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    public class _3DTest
    {
        static void Main()
        {
            Point3D O = Point3D.CoordStart;
            Console.WriteLine(O);
            Point3D A = new Point3D(3, 4, 5);
            Point3D B = new Point3D(8, 1, -3);
            double dist = Distance.CalculateDistance(A, B);
            Console.WriteLine(dist);
            //PathStorage.SavePath(3); // paths saved in file
            PathStorage.LoadPath(6);
            Console.WriteLine("Load path 6");
            Console.WriteLine(Path.Print());
        }
    }
}
