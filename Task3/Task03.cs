using System;
using Library_Task8;

namespace Task03
{
    class Task03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana");
            int anynumber = Library.CheckForDigits("Please enter anynumber:  ");
            Console.WriteLine("is the last digit of given number is 7");
            bool check = Library.NumberendsWithDigit7(anynumber);
        }
    }
}
