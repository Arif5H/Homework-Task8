using System;
using Library_Task8;

namespace Task12
{
    class Task12
    {
        static void Main(string[] args)
        {   /*Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir. 
             Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
             Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.*/
            Console.WriteLine("Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir");
            step:
            int number = Library.CheckForDigits("PLease enter 6-digit number: ");
            try
            {
                number = Library.Check6DigitNumber(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try Again");
                goto step;
            }
            number = number * 10 + 80000008;
            Console.WriteLine("Typed 8 in the beginnig and end of the value and got new vaue {0}", number);
            Console.WriteLine(" Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish");
            int number1 = number % 10000;
            number1 = number1 * 10000 + number / 10000;
            Console.WriteLine("Result: {0}", number1);
            Console.WriteLine(" Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.Example:  {0,1,2,3,4,5,6,7} Change digit in 1,3,5,7 to 0 ");

             
            int count=0;
            int remainder;
            number = 0;
            while(number1>0)
            {
                remainder = number1 % 10;
                number1 /= 10;
                number = number * 10 + remainder;
            }
            number1 = number;
            number = 0;
            while(number1>0)
            {
                remainder = number1 % 10;
                number1 /= 10;
                if(count%2 == 0)
                {
                    number = number*10 + remainder;
                }
                else
                {
                    number = number * 10 + 0;

                }
                count++;
            }
            Console.WriteLine("The Final Result {0}", number);

        }
    }
}
