using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lowerlimit= ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the upperlimit= ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All the integers between upperlimit and lowerlimit are:");
            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
