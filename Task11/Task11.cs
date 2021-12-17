using System;
using Library_Task8;

namespace Task11
{
    class Task11
    {
        static void Main(string[] args)
        {   /*Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse o zaman
        	bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
               Neticenin ustune ortaya dushen 2 reqemini gel. */
            Console.WriteLine("Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse o zaman bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.");
           
            step:
                int number = Library.CheckForDigits("Please enter 6-digit number:  ");
                try
                {
                    number = Library.Check6DigitNumber(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto step;
                }
                number = Library.DigitsOfNumber(number, out int number1, out int number2);
                int number3;
                int number4;


                if (number2 == number1)
                {
                    number3 = number % 100;
                    Console.WriteLine("Last 2 digits of 6-digit number {0}", number3);
                    number4 = number / 10000;
                    Console.WriteLine("1st 2 digits of 6-digit number {0}", number4);

                    number4 = number4 * 100 + number3;
                    Console.WriteLine("Sum of 1st and last 2-digits of 6-digit number {0}", number4);
                    Console.WriteLine($"Add to the result {number4} the 2-digits of 6-digit number which are located in the middle");
                    number %= 10000;
                    number /= 100;
                    Console.WriteLine("2-digitsin the middle {0}", number);
                    number += number4;
                    Console.WriteLine("Result of sum {0}", number);
                    
                }
                else
                {
                    Console.WriteLine("The sum of 1st and last 3 digits not equal. Try another 6-digit number");
                    
                    goto step;

                }
        }       //3 attempt olsun
              //Nece eleyimki if ==true olsa sadece Congrats gelsin
              //ve else == true olsa - 3 loopdan sonra desin NO ATTEMPTS left
            
        
    }
}
