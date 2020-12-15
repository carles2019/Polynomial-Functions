using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input points in x y representation");
            List<Point> points = new List<Point>() { new Point(1, -1), new Point(-2, 3), new Point(5, 1) };

            Coordinate cooridnate = new Coordinate(points);
            cooridnate.DisplayCoordinate();

            EquationSystem equation = new EquationSystem(cooridnate);
            equation.SetMatrix();
            equation.DisplayMatrix();
            equation.DisplayResult();

            Polynomial poly = new Polynomial(equation.GetRoot());
            poly.DisplayPolynomial();
            poly.CalculatePolynomial();
            poly.DisplayPolynomialResult();
            poly.getDerivativeCoefficient();
            poly.DisplayDerivative();
        }
    }
}
