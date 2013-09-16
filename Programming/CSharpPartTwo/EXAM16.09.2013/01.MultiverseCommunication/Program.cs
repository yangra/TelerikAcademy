using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultiverseCommunication
{
    class Program
    {
        static int GetDigit(string digit)
        {
            switch (digit)
            {
                case "CHU": return 0;
                case "TEL": return 1;
                case "OFT": return 2;
                case "IVA": return 3;
                case "EMY": return 4;
                case "VNB": return 5;
                case "POQ": return 6;
                case "ERI": return 7;
                case "CAD": return 8;
                case "K-A": return 9;
                case "IIA": return 10;
                case "YLO": return 11;
                case "PLA": return 12;
            }
            return - 1;
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            List<int> answer = new List<int>();
            for (int i = 0; i < number.Length;)
            {
                for (int j = 0; j < 3; j++)
                {
                    digit.Append(number[i]);
                    i++;
                }
               answer.Add(GetDigit(digit.ToString()));
               digit.Clear();
            }
            BigInteger result = 0;
            BigInteger powerOf13 = 1;
            for (int i = answer.Count - 1; i >= 0; i--, powerOf13 *= 13)
            {
                result += answer[i] * powerOf13;
            }
            Console.WriteLine(result);
        }
    }
}
