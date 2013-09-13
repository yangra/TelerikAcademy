using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenomeDecoder
{
    static bool IsNumber(char letter)
    {
        if (letter>='0'&&letter<='9')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        string[] rawDims = Console.ReadLine().Split();
        int lineLength = int.Parse(rawDims[0]);
        int wordLength = int.Parse(rawDims[1]);
        string codedGenome = Console.ReadLine();
        StringBuilder number = new StringBuilder();
        List<int> coefficients = new List<int>();
        List<char> genomeChars = new List<char>();
        StringBuilder decodedGenome = new StringBuilder();

        for (int i = 0; i < codedGenome.Length; i++)
        {
            int coef = 0;
            int dec = 1;
            while (IsNumber(codedGenome[i]))
            {
                number.Append(int.Parse(codedGenome[i].ToString()));
                i++;
            }
            if (number.Length>0)
            {
                while (number.Length>0)
                {
                    int digit = int.Parse(number[number.Length - 1].ToString());
                    coef += digit * dec;
                    dec *= 10;
                    number.Remove(number.Length - 1, 1);
                }
                coefficients.Add(coef);
            }
            else
            {
                coefficients.Add(1);
            }
            genomeChars.Add(codedGenome[i]);
        }
        int numberOfChars = 0;
        for (int i = 0; i < coefficients.Count; i++)
        {
            numberOfChars += coefficients[i];
        }
        int numberOfLines = numberOfChars / lineLength;
        int additive = numberOfChars % lineLength;
        if (additive>0)
        {
            numberOfLines++;
        }
        for (int i = 0; i < coefficients.Count; i++)
        {
            for (int j = 0; j < coefficients[i]; j++)
            {
                decodedGenome.Append(genomeChars[i]);
            }
        }
        int fix = numberOfLines;
        int align = 0;
        while (fix!=0)
        {
            fix /= 10;
            align++;
        }
        int index = 0;
        StringBuilder resultLine = new StringBuilder();
        List<string> result = new List<string>();
        for (int i = 1; i <= numberOfLines; i++)
        {
            resultLine.Append(i.ToString().PadLeft(align));
            resultLine.Append(" ");
            bool breakOuterCycle = false;
            for (int k = 0; k < lineLength;)
            {
                for (int j = 0; j < wordLength; j++)
                {
                    resultLine.Append(decodedGenome[index]);
                    index++;
                    k++;
                    if (index == decodedGenome.Length)
                    {
                        breakOuterCycle = true;
                        if (j==wordLength-1&&k!=lineLength)
                        {
                            resultLine.Append(" ");
                        }
                        break;
                    }
                    if (k==lineLength)
                    {
                        breakOuterCycle = true;
                        break;
                    }
                }
                if (breakOuterCycle)
                {
                    break;
                }
                resultLine.Append(" ");
            }
            result.Add(resultLine.ToString());
            resultLine.Clear();
            
        }
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

