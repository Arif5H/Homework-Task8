using System;
using Library_Task8;

namespace Task13
{
    class Task13
    {
        static void Main(string[] args)
        {   /**/
            Console.WriteLine("Verilmish 7 reqemli eded polindromdursa  o zaman onun daxilnde nece dene 0 reqemi oldugunu tap?");
        step:
            int number = Library.CheckForDigits("Please enter 7-digit number:  ");
            try
            {
                number = Library.Check7DigitNumber(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("TRY Another number");
                goto step;
            }
            int remainder;
            int reverse = 0;
            int slot = number;
            while(number>0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number {0}", reverse);
            number = slot;
            if (number == reverse)
            {
                Console.WriteLine($"Number {number} = Reverse Number {reverse} -- 7-digit number is Palindomic");
                int count = 0;
                while(number>0)
                {
                    remainder = number % 10;
                    if(remainder == 0)
                    {
                        count++;
                    }
                    number /= 10;
                }
                Console.WriteLine("7-digit number contains {0} zero-digits",count);
            }
            else
            {
                Console.WriteLine("Entered number is not Palindromic");
            }

        }
    }
}
