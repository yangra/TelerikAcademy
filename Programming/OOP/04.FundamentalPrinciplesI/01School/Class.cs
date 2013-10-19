using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Class
    {
        private string id;
        private List<Student> group;
        private List<Teacher> teachers;

        public string Id { get; set; }
        public List<Student> Group { get; private set; }
        public List<Teacher> Teachers { get; private set; }
    }
}
