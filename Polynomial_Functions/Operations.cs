using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Functions
{
    class Operations
    {
        public int Row, Col;
        public double[,] matrix;

        public Operations(double[,] newMatrix)
        {
            matrix = newMatrix;
            Row = matrix.GetLength(0);
            Col = matrix.GetLength(1);
        }

        public double[,] ForwardEliminationMatrix()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = i + 1; j < Row; j++)
                {
                    double factor = matrix[j, i] / matrix[i, i];

                    for (int k = i; k < Col; k++)
                    {
                        matrix[j, k] -= factor * matrix[i, k];
                    }
                }
            }
            return matrix;
        }

        public double[] BackwardsSubstitution()
        {
            double[] result = new double[Row];
        
            for (int i = Row - 1; i >= 0; i--)
            {
                result[i] = matrix[i, Col - 1];
                for (int j = i + 1; j <= Row - 1; j++)
                {
                    result[i] -= matrix[i, j] * result[j];
                }
                result[i] = result[i] / matrix[i, i];
            }
            return result;
        }

        private void SwapRow(int rowA, int rowB)
        {
            double[] temp = new double[Col];
            for (int i = 0; i < Col; i++)
            {
                temp[i] = matrix[rowA, i];
                matrix[rowA, i] = matrix[rowB, i];
                matrix[rowB, i] = temp[i];
            }
        }

        public void Pivoting()
        {
            for (int i = 0; i < Col - 1; i++)
            {
                double maxPivot = matrix[i, i];
                for (int j = i + 1; j < Row; j++)
                {
                    if (matrix[j, i] > maxPivot && matrix[j, i] != 0)
                    {
                        maxPivot = matrix[j, i];
                        SwapRow(i, j);
                    }
                }
            }
        }

        public void DisplayMatrix()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
