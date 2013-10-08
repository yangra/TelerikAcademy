using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
                    AttributeTargets.Interface | AttributeTargets.Enum |
                    AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : System.Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Version = major + "." + minor.ToString().PadLeft(3, '0');
        }
    }
}
