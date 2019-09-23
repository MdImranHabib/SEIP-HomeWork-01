using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumofSquare = 0;
            int squareofSum = 0;

            for(int i = 1; i <= 100; i++)
            {
                squareofSum = squareofSum + i;
                sumofSquare = sumofSquare + (i*i);
            }
            squareofSum = (squareofSum * squareofSum);

            Console.Write("The square of sum is: ");
            Console.WriteLine(squareofSum);

            Console.Write("The sum of square is: ");
            Console.WriteLine(sumofSquare);

            Console.Write("The difference between square of sum and sum of square is: ");
            Console.WriteLine(squareofSum - sumofSquare);
            Console.ReadKey();
        }
    }
}
