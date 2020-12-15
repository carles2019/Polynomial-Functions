using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Functions
{
    class Polynomial
    {
        public double[] coefficients;
        public double[] coefficientDer;
        private int exponent;

        public Polynomial(double[] newCoefficients)
        {
            coefficients = newCoefficients;

            int n = coefficients.Length;
            exponent = n - 1;
            coefficientDer = new double[n - 1];
        }

        public void DisplayPolynomial()
        {
            Console.WriteLine("Calculated polynomial: ");
            Console.Write("f(x) = ");

            for (int i = 0; i < coefficients.Length; i++)
            {
                if (exponent > 0)
                {
                    Console.Write("{0}x^{1}", Math.Round(coefficients[i], 4), exponent);
                }
                else
                {
                    Console.Write(Math.Round(coefficients[i], 2));
                }

                exponent--;
            }
            Console.WriteLine();
        }

        public double[] CalculatePolynomial()
        {
            double[] result = new double[3];
            
            for (int i = 0; i < 3; i++)
            {
                int n = -1;
                for (int j = 0; j < coefficients.Length; j++)
                {
                    result[i] += coefficients[j] * Math.Pow((n + i), exponent);
                    exponent--;
                }
                exponent = coefficients.Length - 1;
            }
            return result;
        }

        public double[] getDerivativeCoefficient()
        {
            int tmp = exponent;
            for (int i = 0; i < exponent; i++)
            {
                coefficientDer[i] = tmp * coefficients[i];
                tmp--;
            }
            return coefficientDer;
        }

        public void DisplayDerivative()
        {
            Console.WriteLine("Derivative: ");
            Console.Write("f'(x) = ");
            int derivativeExp = coefficientDer.Length - 1;
            for (int i = 0; i < exponent; i++)
            {
                if (derivativeExp > 0)
                {
                    Console.Write("{0}x^{1}", Math.Round(coefficientDer[i], 5), derivativeExp);
                }
                else
                {
                    Console.Write("{0}", Math.Round(coefficientDer[i], 5));
                }
                derivativeExp--;
            }
            Console.WriteLine();
        }

        public void DisplayPolynomialResult()
        {
            double[] val = CalculatePolynomial();
            int x = -1;
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine("f({0}) = {1}", x + i, Math.Round(val[i], 4));
            }
        }
    }
}
