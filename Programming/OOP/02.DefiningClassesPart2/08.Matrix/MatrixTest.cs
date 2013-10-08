using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Matrix
{
    class MatrixTest
    {
        public static void Main()
        {
            Matrix<double> first = new Matrix<double>(3, 5);
            Matrix<double> second = new Matrix<double>(3, 5);
            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < first.Cols; j++)
                {
                    first[i, j] = 0.5 * (i + j);
                    second[i, j] = 0.2 * (i - j);
                }
            }
            Matrix<double> sum = first + second;
            Matrix<double> substract = first - second;
            Console.WriteLine("First:");
            Console.WriteLine(first);
            Console.WriteLine("Second:");
            Console.WriteLine(second);
            Console.WriteLine("Sum:");
            Console.WriteLine(sum);
            Console.WriteLine("Substraction:");
            Console.WriteLine(substract);
            Matrix<int> one = new Matrix<int>(2, 3);
            Matrix<int> two = new Matrix<int>(3, 2);
            int value = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    one[i, j] = value;
                    two[j, i] = value + 6;
                    value++;
                }
            }
            Matrix<int> ans = one * two;
            Console.WriteLine("One:");
            Console.WriteLine(one);
            Console.WriteLine("Two:");
            Console.WriteLine(two);
            Console.WriteLine("Multiplication:");
            Console.WriteLine(ans);
            if (ans)
            {
                Console.WriteLine("No zero cells in the matrix");
            }
            else
            {
                Console.WriteLine("At least one zero cell in the matrix");
            }
        }
    }
}
