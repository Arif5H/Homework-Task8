using System;
using Library_Task8;

namespace Task06
{
    class Task06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana");
            step:
            int number = Library.CheckForDigits(" Please enter 3-digit number:  ");
            try
            {
                number = Library.Check3DigitNumber(number);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try Again");
                goto step;
            }
            int[] array = new int[3];
            int remainder;
            int i = 0;
            while (number>0)
            {
                remainder = number % 10;
                Console.WriteLine($"{i+1} digit is {remainder}");
                array[i] = remainder; 
                number /= 10;
                i++;
            }
                if(array[0]+array[2] == array[1])
                {
                Console.WriteLine("Beli {0}", true);
                }
                else
                {
                Console.WriteLine("Xeyr {0}", false);
                }



        }
    }
}
