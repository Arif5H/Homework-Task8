using System;
using Library_Task8;

namespace Task02
{
    class Task02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart. Eks halda  'bolunmur' sozunu cap et");
            int number1 = Library.CheckForDigits("Please enter 1st value:  ");
            int number2 = Library.CheckForDigits("Please enter 2nd value:  ");
            Library.Devide(number1, number2);

        }
    }
}
