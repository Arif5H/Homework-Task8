using System;

namespace Task10
{
    class Task10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IF operatoru ile yoxla. 6 dene eded verilib.Bu ededlerden hansi en boyukdur.");
            Random num = new Random();
            int randomnum;
            int i = 1;
            int max = 0;
            Console.WriteLine("Original max value {0}", max);
            while(i<7)
            {
                randomnum = num.Next(0, 1000);
                Console.WriteLine($"{i} Random number {randomnum}");
                if (max< randomnum)
                {
                    max = randomnum;
                }
                Console.WriteLine($"{max} is max value");
                i++;
            }
        }
    }
}
