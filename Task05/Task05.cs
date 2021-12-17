using System;
using Library_Task8;

namespace Task05
{
    class Task05
    {
        static void Main(string[] args)
        {   /*Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman 
	        hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.*/
            Console.WriteLine("Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.");
            step:
            int number = Library.CheckForDigits("Please enter 2-digit number:  ");
            try
            {
                number = Library.Check2DigitNumber(number);

            }
                catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try Again");
                goto step;
            }
            try
            {
                number = Library.IfEVENFindProductOfDigits(number);
                Console.WriteLine($"Product of digits of number is {number}");
            }
             catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try Another number");
                goto step;
            }
        }
    }
}
