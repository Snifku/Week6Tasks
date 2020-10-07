using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; ++i)
                randomArray[1] = rnd.Next(1, 11);
            Console.WriteLine(randomArray[0] + randomArray[1] + randomArray[2] + randomArray[3] + randomArray[4] + randomArray[5] + randomArray[6] + randomArray[3] + randomArray[7] + randomArray[8] + randomArray[9]);

        }
    }
}
