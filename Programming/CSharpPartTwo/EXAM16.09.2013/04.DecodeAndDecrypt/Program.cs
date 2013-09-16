using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DecodeAndDecrypt
{
    class Program
    {
        static StringBuilder answer = new StringBuilder();

        static void Main(string[] args)
        {
            StringBuilder length = new StringBuilder();
                string input = Console.ReadLine();
                int index = input.Length - 1;
                while (char.IsDigit(input[index]))
                {  
                    index--;
                }
                index++;
                int lengthOfCypher = int.Parse(input.Substring(index));
                input = input.Remove(index);
                string decoded = Decode(input);
                StringBuilder cyph = new StringBuilder();
                for (int i = decoded.Length - lengthOfCypher; i < decoded.Length; i++)
                {
                    cyph.Append(decoded[i]);
                }
                string cypher = cyph.ToString();
                string message = decoded.Remove(decoded.Length - lengthOfCypher);
                Encrypt(message, cypher);
                Console.WriteLine(answer);
        }

        private static string Decode(string input)
        {
            StringBuilder number = new StringBuilder();
            StringBuilder decoded = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    while (char.IsDigit(input[i]))
                    {
                        number.Append(input[i]);
                        i++;
                    }
                    int repeat = int.Parse(number.ToString());
                    number.Clear();
                    for (int j = 0; j < repeat; j++)
                    {
                        decoded.Append(input[i]);
                    }
                }
                else
                {
                    decoded.Append(input[i]);
                } 
            }
            return decoded.ToString();
        }

        private static void Encrypt(string message, string key)
        {
            
            if (message.Length>=key.Length)
            {
                int j = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    int letterCode = message[i] - 'A';
                    int keyCode = key[j] - 'A';
                    char symbol = (char)((letterCode ^ keyCode) + 65);
                    answer.Append(symbol);
                    j++;
                    if (j>key.Length-1)
                    {
                        j = 0;
                    }
                }
            }
            else
            {
                List<char> changedMessage = new List<char>();
                for (int i = 0; i < message.Length; i++)
                {
                    changedMessage.Add(message[i]);
                }
                int j = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    int letterCode = changedMessage[j] - 'A';
                    int keyCode = key[i] - 'A';
                    char symbol = (char)((letterCode ^ keyCode) + 65);
                    changedMessage[j] = symbol;
                    j++;
                    if (j > changedMessage.Count - 1)
                    {
                        j = 0;
                    }
                }
                for (int i = 0; i < changedMessage.Count; i++)
                {
                    answer.Append(changedMessage[i]);
                }
            }
        }
    }
}
