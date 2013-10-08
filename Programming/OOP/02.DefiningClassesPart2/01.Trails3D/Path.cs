using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    public static class Path
    {
        private static List<Point3D> sequence;
        public static List<Point3D> Sequence
        {
            get
            {
                return sequence;
            }
            set
            {
                sequence = value;
            }
        }

        public static string Print()
        {
            StringBuilder path = new StringBuilder();
            for (int i = 0; i < sequence.Count; i++)
            {
                path.AppendFormat("({0},{1},{2})", sequence[i].X, sequence[i].Y, sequence[i].Z);
            }
            return path.ToString();
        }
    }
}
