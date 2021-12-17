using System;
using Library_Task8;

namespace Task04
{
    class Task04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana");
            step:
            int anynumber = Library.CheckForDigits("Please enter 2 - digit number:  ");
            try
            {
                anynumber =Library.Check2DigitNumber(anynumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try Again");
                goto step;
            }
            int box = anynumber % 10;
            anynumber /= 10;
            anynumber %= 10;
            if (box == anynumber)
            {
                Console.WriteLine($"{true} digits are of number are equal {box} = {anynumber}");
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
