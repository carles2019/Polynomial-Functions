using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Functions
{
    class VenderMatrix
    {
        public int Row, Col;
        public double[,] matrix;
        public Coordinate coordinate;

        public VenderMatrix(Coordinate coordinate)
        {
            this.coordinate = coordinate;
            Row = this.coordinate.coordinatesList.Count;
            Col = Row + 1;
            matrix = new double[Row, Col];
        }

        public void SetMatrix()
        {
            int exponent = Row - 1;
            for (int i = 0; i < Row; i++)
            {
                double x = coordinate.coordinatesList[i].x;
                double y = coordinate.coordinatesList[i].y;
                for (int j = 0; j < Col; j++)
                {
                    if (j == Col - 2)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == Col - 1)
                    {
                        matrix[i, j] = y;
                    }
                    else
                    {
                        matrix[i, j] = Math.Pow(x, exponent);
                    }
                    exponent--;
                }
                exponent = coordinate.coordinatesList.Count() - 1;
            }
        }

        public double[,] GetMatrix()
        {
            return this.matrix;
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
