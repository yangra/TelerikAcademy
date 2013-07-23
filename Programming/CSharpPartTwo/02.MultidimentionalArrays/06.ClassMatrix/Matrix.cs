//*Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, 
//indexer for accessing the matrix content and ToString().

using System;

class Matrix
{
    private int dimX = 3;
    private int dimY = 3;
    private int[,] matrix;

    public Matrix(int X, int Y)
    {
        this.dimX = X;
        this.dimY = Y;
        this.matrix = new int[X, Y];
    }

    public int this[int X, int Y]
    {
        get
        {
            return matrix[X, Y];
        }
        set
        {
            matrix[X, Y] = value;
        }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix result = new Matrix(a.dimX,a.dimY);
        for (int row = 0; row < a.dimX; row++)
        {
            for (int col = 0; col < a.dimY; col++)
            {
                result[row, col] = a[row, col] + b[row, col];
            }   
        }
        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        Matrix result = new Matrix(a.dimX, a.dimY);
        for (int row = 0; row < a.dimX; row++)
        {
            for (int col = 0; col < a.dimY; col++)
            {
                result[row, col] = a[row, col] - b[row, col];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        Matrix result = new Matrix(a.dimX, b.dimY);
        for (int row = 0; row < a.dimX; row++)
        {
            for (int col = 0; col < b.dimY; col++)
            {
                for (int i = 0; i < a.dimY; i++)
                {
                    result[row,col] += a[row,i]*b[i,col];
                }
            }
        }
        return result;
    }

    public override string ToString()
    {
        string result = "";
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result += matrix[row, col].ToString().PadLeft(4,' ');
            }
            result += "\n";
        }
        return result;
    }

    static void Main()
    {
        Matrix a = new Matrix(4, 3);
        Matrix b = new Matrix(4, 3);
        Matrix c = new Matrix(3, 4);


        // Fill with random numbers
        Random randomGenerator = new Random();
        for (int i = 0; i < a.dimX; i++)
        {
            for (int j = 0; j < a.dimY; j++)
            {
                a[i, j] = randomGenerator.Next(20);
                b[i, j] = randomGenerator.Next(20);
            }
        }
        for (int i = 0; i < c.dimX; i++)
        {
            for (int j = 0; j < c.dimY; j++)
            {
                c[i, j] = randomGenerator.Next(20);
            }
        }

        Console.WriteLine("Matrix 1");
        Console.WriteLine(a);

        Console.WriteLine("Matrix 2");
        Console.WriteLine(b);

        Console.WriteLine("Matrix 3");
        Console.WriteLine(c);

        Console.WriteLine("Matrix 1 + Matrix 2");
        Console.WriteLine(a + b);

        Console.WriteLine("Matrix 1 - Matrix 2");
        Console.WriteLine(a - b);

        Console.WriteLine("Matrix 1 * Matrix 3");
        Console.WriteLine(a * c);
    }
}

