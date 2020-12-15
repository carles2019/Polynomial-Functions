using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Functions
{
    
    public class Point
    {
        public double x, y;

        public Point(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
    }

    public class Coordinate
    {
        public List<Point> coordinatesList;

        public Coordinate()

        {
            coordinatesList = new List<Point>();
        }

        public Coordinate(List<Point> newCoordinatesList)
        {
            coordinatesList = newCoordinatesList;
        }

        public void SetCoordinates()
        {
            bool flag = true;
            int pointIterator = 1;
            string input;

            while (flag)
            {
                Console.Write($"Point#{pointIterator}: ");
                input = Console.ReadLine();

                string[] split = input.Split(',');

                if (input.ToUpper() != "END")
                {
                    coordinatesList.Add(new Point(double.Parse(split[0]), double.Parse(split[1])));
                    pointIterator++;
                }
                else
                {
                    flag = false;
                }
            }
        }

        public void DisplayCoordinate()
        {
            for (int i = 0; i < coordinatesList.Count; i++)
            {
                Console.Write("({0},{1})", coordinatesList[i].x, coordinatesList[i].y);
                Console.WriteLine();
            }
        }
    }
    
}
