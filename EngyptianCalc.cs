using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianCalculator
{
    class EngyptianCalc
    {
        // - Public function to get first & second number
        public static int[] getTwoNumbers()
        {
            Console.WriteLine("Enter Two numbers to Multiply. \n");

            Console.WriteLine("Multiplicand: \n");
            int multiplicand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplier: \n");
            int multiplier = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[] { multiplicand, multiplier };

            return numbers;
        }

        private static void MultiplicationByDoubling()
        {
            Console.WriteLine("\nMultiplicationByDoubling");
            
            int[] numbers = getTwoNumbers();

            // Numbers to multiply.
            int multiplicand = numbers[0];
            int multiplier = numbers[1];

            Console.WriteLine("You've Entered: {0} X {1} to multiply", multiplicand, multiplier);
        }

        private static void MultiplicationByHalving()
        {
            Console.WriteLine("\nMultiplicationByHalving");
        }

        // - Driver Function
        static void Main()
        {
            Console.WriteLine("Select Multiplication Type: \n-------------------- \n | 1 - Doubling. \n | 2 - Halving. \n | 3 - Addtion. \n--------------------");

            int multiplicationType = Convert.ToInt32(Console.ReadLine());

            if (multiplicationType == 1)
            {
                MultiplicationByDoubling();
            }
            else if(multiplicationType == 2)
            {
                MultiplicationByHalving();
            }
            else
            {
                Console.WriteLine("Not Applicable");
            }

        }

    }
}
