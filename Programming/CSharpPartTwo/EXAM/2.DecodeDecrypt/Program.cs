using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DecodeDecrypt
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int lengthOfCypher = int.Parse(input[input.Length-1].ToString());
            input = input.Remove(input.Length - 1);
        }
    }
}
