using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    public static class PathStorage   
    {
        private static int savedPaths;

        static PathStorage()
        {
            int count = 0;
            StreamReader reader = new StreamReader(@"../../paths.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                    count++;
                    line = reader.ReadLine();
                } 
            }
            savedPaths = count;
        }

        public static void SavePath(int length)
        {
            StringBuilder path = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Point{0} X: ", i+1);
                int x = int.Parse(Console.ReadLine());
                Console.Write("Point{0} Y: ", i + 1);
                int y = int.Parse(Console.ReadLine());
                Console.Write("Point{0} Z: ", i + 1);
                int z = int.Parse(Console.ReadLine());
                if (i!=length-1)
                {
                    path.AppendFormat("{0},{1},{2}|", x, y, z);
                }
                else
                {
                    path.AppendFormat("{0},{1},{2}", x, y, z);
                }
                
            }
            StreamWriter writer = new StreamWriter(@"../../paths.txt",true);
            using (writer)
            {
                writer.WriteLine(path);
            }
            savedPaths++;
        }

        public static void LoadPath(int number)
        {
            if (number> savedPaths )
            {
                throw new ArgumentOutOfRangeException("There is not such saved path");  
            }
            List<Point3D> seq = new List<Point3D>();
            StreamReader read = new StreamReader(@"../../paths.txt");
            using (read)
            {
                string path = "";
                for (int i = 0; i < number; i++)
                {
                    path = read.ReadLine();
                }
                string[] points = path.Split('|');
                for (int i = 0; i < points.Length; i++)
                {
                    string[] xyz = points[i].Split(',');
                    Point3D point = new Point3D();
                    point.X = int.Parse(xyz[0]);
                    point.Y = int.Parse(xyz[1]);
                    point.Z = int.Parse(xyz[2]);
                    seq.Add(point);  
                }
            }
            Path.Sequence = seq;
        }
    }
}
