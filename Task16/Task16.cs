using System;
using Library_Task8;

namespace Task16
{
    class Task16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Verilmish 6 reqemli ededde nece unikal reqem var ?");
            Console.WriteLine("( UNIKAL- Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)");
        step:
            int number = Library.CheckForDigits("Pleasse enter 6-digit number:   ");
            try
            {
                number = Library.Check6DigitNumber(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                goto step;
            }

            int[] arr = new int[0];
            while(number>0)
            {
                int remainder = number % 10;
                number /= 10;
                if(Array.IndexOf(arr, remainder) == -1)
                {
                    Array.Resize(ref arr, arr.Length+1);
                    
                    arr[arr.Length - 1] = remainder;
                    
                }
            }

            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Array {arr}");
            Console.WriteLine($"Unical numbers {arr.Length}");



        }
    }
}
