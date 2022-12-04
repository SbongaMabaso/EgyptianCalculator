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
        public class pair
        {
            public int first, second;
            public pair(int first, int second)
            {
                this.first = first;
                this.second = second;
            }
        }
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

        private static void MultiplicationByDoubling(int multiplicand, int multiplier)
        {
            Console.WriteLine("\n---| MultiplicationByDoubling |---");

            int value = 1;
            var firstColumn = new ArrayList();
            //Add powers of two to the first column (multiplicand)
            while(value <= multiplicand)
            {
                firstColumn.Add(value);
                value = 2 * value;
            }

            Console.WriteLine("First Column:\n");
            for(int i = 0; i<firstColumn.Count; i++)
            {
                Console.WriteLine(firstColumn[i] + ", ");
            }
            

            //Create array for the second column
            var secondColumn = new ArrayList();
            for (int i=0; i<firstColumn.Count; i++)
            {
                secondColumn.Add(multiplier);
                multiplier = 2 * multiplier;
            }
            Console.WriteLine("First Column:\n");
            for (int i = 0; i < secondColumn.Count; i++)
            {
                Console.WriteLine(secondColumn[i] + ", ");
            }

            //Find elements that add up to a Multiplicand (firstColumn) and store in a hash table
            Dictionary<int, pair> map = new Dictionary<int, pair>();
            for(int i=0; i<firstColumn.Count; i++)
            {
                for(int j=i+1; j<firstColumn.Count; j++)
                {
                    if (map.ContainsKey((int)firstColumn[i] + (int)firstColumn[j]))
                    {
                        map[(int)firstColumn[i] + (int)firstColumn[j]] = new pair(i, j);
                    }
                    else
                    {
                        map.Add((int)firstColumn[i] + (int)firstColumn[j], new pair(i, j));
                    }
                }
            }
            //Traverse through all the pairs and search for multiplicand
            for(int i=0; i<firstColumn.Count; i++)
            {
                for (int j=i+1; j<firstColumn.Count; j++)
                {
                    int sum = (int)firstColumn[i] + (int)firstColumn[j];
                    //if multiplicand is present in the hash table
                    if(map.ContainsKey(multiplicand - sum))
                    {
                        pair p = map[multiplicand - sum];
                        if(p.first != i && p.first != j && p.second != i && p.second != j)
                        {
                            Console.WriteLine(firstColumn[i] + ", " + firstColumn[j] + ", " + firstColumn[p.first] + ", " + firstColumn[p.second]);
                            return;
                        }
                    }
                }
            }
        }

        private static int MultiplicationByHalving(int multiplicand, int multiplier)
        {
            int product;

            if(multiplicand == 1)
            {
                product = multiplier;
            }
            else if (multiplicand % 2 != 0)
            {
                product = multiplier + MultiplicationByHalving(multiplicand / 2, 2 * multiplier);
            }
            else //if(multiplicand % 2 == 0)
            {
                product = MultiplicationByHalving(multiplicand / 2, 2 * multiplier);
            }

            int product_temp = 0;
            if(product >= product_temp)
            {
                product_temp = product;
            }
            Console.WriteLine("\nSteps: {0} -> {1}", multiplicand, multiplier);
            Console.WriteLine("\nProduct: {0}", product_temp);
            return product;
        }

        // - Driver Function
        static void Main()
        {
            Console.WriteLine("Select Multiplication Type: \n-------------------- \n | 1 - Doubling. \n | 2 - Halving. \n | 3 - Addtion. \n--------------------");

            int multiplicationType = Convert.ToInt32(Console.ReadLine());

            int[] numbers = getTwoNumbers();

            // Numbers to multiply.
            int multiplicand = numbers[0];
            int multiplier = numbers[1];

            if (multiplicationType == 1)
            {
                MultiplicationByDoubling(multiplicand, multiplier);
            }
            else if(multiplicationType == 2)
            {
                MultiplicationByHalving(multiplicand, multiplier);
            }
            else
            {
                Console.WriteLine("Not Applicable");
            }

        }

    }
}
