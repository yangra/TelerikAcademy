using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Guitar
{
    static void Main()
    {
        //Console.WriteLine(-1);
        string[] rawInput = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        int[] volumes = new int[rawInput.Length];
        for (int i = 0; i < volumes.Length; i++)
        {
            volumes[i] = int.Parse(rawInput[i]);
        }
        int initialVolume = int.Parse(Console.ReadLine());
        int maxVolume = int.Parse(Console.ReadLine());
        long numberOfVariations = (long)Math.Pow(2, volumes.Length);
        int result = -1;
        for (long i = 1; i < numberOfVariations; i++)
        {
            int sum = initialVolume;
            bool notFinished = false;
            for (int j = 0; j < volumes.Length; j++)
            {

                long mask = 1;
                long masked = (i & (mask << j)) >> j;
                if (masked == 1)
                {
                    sum += volumes[j];
                }
                else
                {
                    sum -= volumes[j];
                }
                if (sum < 0 || sum > maxVolume)
                {
                    notFinished = true;
                    break;
                }

            }
            if (!notFinished)
            {
                if (sum > result)
                {
                    result = sum;
                }
            }
        }
        Console.WriteLine(result);
    }
}



