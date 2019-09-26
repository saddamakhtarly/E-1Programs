using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_p = Console.ReadLine().Split(' ');
            int n_apples = Convert.ToInt32(tokens_p[0]);
            int n_oranges = Convert.ToInt32(tokens_p[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
            int apples = 0;
            for (int i = 0; i < n_apples; i++)
            {
                if (a + apple[i] >= s && a + apple[i] <= t) apples++;
            }
            int oranges = 0;
            for (int i = 0; i < n_oranges; i++)
            {
                if (b + orange[i] >= s && b + orange[i] <= t) oranges++;
            }
            Console.WriteLine(apples);
            Console.WriteLine(oranges);
            Console.ReadKey();
        }
    }
}
