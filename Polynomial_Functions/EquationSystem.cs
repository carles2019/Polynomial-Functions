using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Functions
{
    class EquationSystem : VenderMatrix
    {
        private readonly Operations calc;

        public EquationSystem(Coordinate coordinate)
            : base(coordinate)
        {
            calc = new Operations(matrix);
        }

        public double[] GetRoot()
        {
            calc.ForwardEliminationMatrix();
            calc.Pivoting();
            return calc.BackwardsSubstitution();
        }

        public void DisplayResult()
        {
            var result = GetRoot(); ;
            Console.WriteLine("\nResult: ");
            int numX = result.Length;
            for (int i = 0; i < numX; i++)
            {
                Console.WriteLine("X{0}: {1}", i + 1, result[i]);
            }
        }
    }
}
