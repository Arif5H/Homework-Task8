using System;

namespace Library_Task8
{
    public class Library
    {
        public static int CheckForDigits(string caption)
        {
            int anynumber;
            TryAgain:
            Console.Write(caption);
            try
            {
                anynumber = Convert.ToInt32(Console.ReadLine());
                return anynumber;
            }
            catch
            {
                Console.WriteLine("Please enter only digits. Try Again!!");
                goto TryAgain;
            }
        }

        public static int CheckForEvenOrOdd(int anynumber)
        {
            if (anynumber % 2 == 0)
            {
                Console.WriteLine($"The given number is even {anynumber}");
            }
            else 
            {
                Console.WriteLine($"The given number is odd {anynumber}");
            }   
            return anynumber;
        }

        public static void Devide (int number1, int number2)
        {
            int newvalue;
            if (number1%number2 == 0)
            {
                newvalue = number1 / number2;
                Console.WriteLine($" {number1} / {number2} = {newvalue}");
            }
            else
            {
                Console.WriteLine("Bolunmur");  
            }
             
        }

        public static bool NumberndsWithDigit7 (int anynumber)
        {
            
            anynumber %= 10;
            if (anynumber == 7 )
            {
                Console.WriteLine("Beli");
                return true;
            }
            else
            {
                Console.WriteLine("Xeyr");
                return false;
            }
        }

        public static int Check2DigitNumber (int anynumber)
        {
            if(anynumber<10 || anynumber>99)
            {
                throw new Exception ($"Entered number {anynumber} is not 2-digit number");       
            }
            return anynumber;
        }

        public static int Check3DigitNumber(int anynumber)
        {
            if (anynumber < 100 || anynumber > 999)
            {
                throw new Exception($"Entered number {anynumber} is not 3-digit number");
            }
            return anynumber;
        }

        public static int Check6DigitNumber(int anynumber)
        {
            if (anynumber < 100000 || anynumber > 999999)
            {
                throw new Exception($"Entered number {anynumber} is not 6-digit number");
            }
            return anynumber;
        }

        public static int Check7DigitNumber(int anynumber)
        {
            if (anynumber < 1000000 || anynumber > 9999999)
            {
                throw new Exception($"Entered number {anynumber} is not 7-digit number");
            }
            return anynumber;
        }

        public static int CheckIfNumberOftheYear(int anynumber)
        {
            if (anynumber < 1|| anynumber > 365)
            {
                throw new Exception($"Entered number {anynumber} is not  within range 1 to 365");
            }
            return anynumber;
        }

        public static int SumOFDigits(int anynumber)
        {
            int sum=0;
            int remainder;
            int i = 1;
            int number = anynumber;
            while(number>0)
            {
                remainder = number % 10;
                Console.WriteLine($"{i} Digit of number {remainder}");
                sum = sum + remainder;
                number /= 10;
                i++;
            }
            return sum;
        }


        public static int IfEVENFindProductOfDigits(int anynumber)
        {
            int product = 1;
            int sum = SumOFDigits(anynumber);
            if (sum%2 ==0)
            {
                int remainder;
                while (anynumber > 0)
                {
                    remainder = anynumber % 10;
                   
                    product = product * remainder;
                    anynumber /= 10;
                    return product;
                    
                }
            }
            else
            {
                throw new Exception($"The sum of digits of the number is not even");
            }
                return product;

        }

        public static int DigitsOfNumber(int anynumber,out int number1, out int number2)
        {
            int remainder;
            number1 = 0;
            number2 = 0;
            int i = 1;
            int number = anynumber;
            while(anynumber>0)
            {
                remainder = anynumber % 10;
                if (i >0 && i<4)
                {
                    number1 = number1 + remainder;
                }
                else if(i>3 && i<7)
                {
                    number2 = number2 + remainder;
                }
                anynumber /= 10;
                i++;
            }
            
                return number;

            
        }



       
    }
}
