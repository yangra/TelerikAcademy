using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline : Name
    {
        
        private int numOfLectures;
        private int numberOfExcercises;

        public int NumOfLectures { get; set; }
        public int NumOfExcercises { get; set; }
    }
}
