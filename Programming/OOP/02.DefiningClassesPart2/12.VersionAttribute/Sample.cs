using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version(2, 1)]
    class Sample
    {
        static void Main(string[] args)
        {
            Type type = typeof(Sample);
            object[] Attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attrib in Attributes)
            {
                Console.WriteLine("The version of this class is {0} ", attrib.Version);
            }
        }
    }
}
