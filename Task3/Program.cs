using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; ++i)
                randomArray[i] = rnd.Next(1, 11);
            int minint = randomArray[0];
            int maxint = randomArray[0];
            foreach (int value in randomArray)
            {
                if (value < minint) minint = value;
                if (value > maxint) maxint = value;
            }


            int min = randomArray[0];
            int max = randomArray[0];
            foreach(int num in randomArray)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine($"min:{min}");
            Console.WriteLine($"min:{max}");

            
        }
    }
}
