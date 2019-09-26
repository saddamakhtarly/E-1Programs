using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Program
    {
        /*
        1. Let all the input integers are stored in an array arr of length n.
        2. Let the divisor be k.
        3. Let the total divisible pair count be d. Initialize d to 0.
        4. Start a loop which runs with a counter i starting from 0 to n-1.
        4.1 Start a nested loop which runs with a counter j starting from i+1 to n-1
        4.1.1 If arr[i] + arr[j] is wholely divisible by k then increment d by 1.
        4.1.2 Repeat step 4.1.1 for all the array elements until loop termination condition is met.
        4.2 Repeat step 4.1 for all the array elements until loop termination condition is met.
        5. Print d.
            */

        static int DivisibleSumPairs(int k, int[] ar)
        {
            var divisiblePairCount = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        divisiblePairCount++;
                }
            }

            return divisiblePairCount;
        }

        static void Main(String[] args)
        {
            var tokens_n = Console.ReadLine().Split(' ');
            var k = int.Parse(tokens_n[1]);
            var ar_temp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(ar_temp, int.Parse);
            var result = DivisibleSumPairs(k, ar);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
