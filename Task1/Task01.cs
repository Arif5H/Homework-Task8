using System;
using Library_Task8;

namespace Task01
{
    class Task01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("verilmish ededin tek ve ya cut eded oldugunu yoxla");
            int anynumber = Library.CheckForDigits("Please enter anynumber:  ");
            anynumber = Library.CheckForEvenOrOdd(anynumber);


        }
    }
}
