using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_the_Records
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {

            int[] result = { 0, 0 };
            int lowestScoreTracker = 0;
            int greatestScoreTracker = 0;
            int lowestSCore = scores[0];
            int greatestScore = scores[0];
            foreach (var score in scores.Skip(1))
            {
                if (score > greatestScore)
                {
                    greatestScore = score;
                    result[0]++;
                }

                if (score < lowestSCore)
                {
                    lowestSCore = score;
                    result[1]++;
                }
            }

            return result;

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();

        }
    }
}
