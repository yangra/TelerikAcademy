using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Matrix
{
    public class Matrix<T>
        where T : struct, IConvertible, IComparable<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public Matrix(int x = 1, int y = 1)
        {
            if (x > 0 && y > 0)
            {
                this.matrix = new T[x, y];
                this.rows = x;
                this.cols = y;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The matrix size cannot be zero or negative");
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("You're trying to access a field outside the matrix");
                }
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows == m2.Rows && m1.Cols == m2.Cols)
            {
                Matrix<T> answer = new Matrix<T>(m1.Rows, m2.Cols);
                for (int i = 0; i < m1.Rows; i++)
                {
                    for (int j = 0; j < m1.Cols; j++)
                    {
                        dynamic cellA = m1[i, j];
                        dynamic cellB = m2[i, j];
                        answer[i, j] = cellA + cellB;
                    }
                }
                return answer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Matrices must be with the same dimensions");
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows == m2.Rows && m1.Cols == m2.Cols)
            {
                Matrix<T> answer = new Matrix<T>(m1.Rows, m2.Cols);
                for (int i = 0; i < m1.Rows; i++)
                {
                    for (int j = 0; j < m1.Cols; j++)
                    {
                        dynamic cellA = m1[i, j];
                        dynamic cellB = m2[i, j];
                        answer[i, j] = cellA - cellB;
                    }
                }
                return answer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Matrices must be with the same dimensions");
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols == m2.Rows)
            {
                Matrix<T> answer = new Matrix<T>(m1.Rows, m2.Cols);
                for (int i = 0; i < m1.Rows; i++)
                {
                    for (int j = 0; j < m2.Cols; j++)
                    {
                        for (int p = 0; p < m1.Cols; p++)
                        {
                            dynamic cellA = m1[i, p];
                            dynamic cellB = m2[p, j];
                            answer[i, j] += cellA * cellB;
                        }
                    }
                }
                return answer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The rows of the first matrix must be the same number as the columns of the second matrix");
            }
        }

        public static bool operator true(Matrix<T> mtrx)
        {
            for (int i = 0; i < mtrx.Rows; i++)
            {
                for (int j = 0; j < mtrx.Cols; j++)
                {
                    if (mtrx[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> mtrx)
        {
            for (int i = 0; i < mtrx.Rows; i++)
            {
                for (int j = 0; j < mtrx.Cols; j++)
                {
                    if (mtrx[i, j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder array = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    array.AppendFormat("{0,5}", this[i, j]);
                }
                array.AppendLine();
            }
            return array.ToString();
        }
    }
}
