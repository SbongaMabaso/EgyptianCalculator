using System;
using System.Collections;
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
            Console.WriteLine("Enter Two numbers to Multiply:");

            Console.WriteLine("Multiplicand :");
            int multiplicand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplier   :");
            int multiplier = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[] { multiplicand, multiplier };

            return numbers;
        }

        private static int EgyptianMultiplication(int multiplicand, int multiplier)
        {
            int product = 0;
            Console.Write("\n  {0}\t | {1}    | ", multiplicand, multiplier);
            Console.WriteLine("\n-----------------------------");

            if (multiplicand == 1)
            {
                product = multiplier;
            }
            else if (multiplicand % 2 != 0)
            {
                product = multiplier + EgyptianMultiplication(multiplicand / 2, 2 * multiplier);
            }
            else //if(multiplicand % 2 == 0)
            {
                product = EgyptianMultiplication(multiplicand / 2, 2 * multiplier);
            }
            
            Console.Write(" --> | {0} ", product);
            return product;
        }

        // - Driver Function
        static void Main()
        {
            Console.WriteLine("------------------------------");
            int[] numbers = getTwoNumbers();
            
            // Numbers to multiply.
            int multiplicand = numbers[0];
            int multiplier = numbers[1];

            Console.WriteLine("\nYou've Entered {0} X {1}", multiplicand, multiplier);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\n Halving | Doubling | Addition ");
            EgyptianMultiplication(multiplicand, multiplier);
        }
    }
}
