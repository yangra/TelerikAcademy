using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher: Person
    {
        private List<Discipline> subjects;

        public string Subjects { get; set; }


    }
}
