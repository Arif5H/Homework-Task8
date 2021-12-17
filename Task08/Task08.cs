using System;
using Library_Task8;

namespace Task08
{
    class Task08
    {
        static void Main(string[] args)
        {   /*SWITCH operatoru ile yoxla. 
                Verilmish ededdin sonuncu reqemi 
			 	1 olarsa-"I gun" sozunu 
				2 olarsa-"II gun" sozunu
				...
				7 olarsa-"VI gun" sozunu yaz*/
            Console.WriteLine("Solve using switch");
            int anynumber = Library.CheckForDigits("Please enter any number");
            
            switch (anynumber%10)
            {
                case 1:
                    Console.WriteLine("1 st day");
                    break;
                case 2:
                    Console.WriteLine("2nd day");
                    break;
                case 3:
                    Console.WriteLine("3rd day");
                    break;
                case 4:
                    Console.WriteLine("4th day");
                    break;
                case 5:
                    Console.WriteLine("5th day");
                    break;
                case 6:
                    Console.WriteLine("6th day");
                    break;
                case 7:
                    Console.WriteLine("7th day");
                    break;
                default:
                    Console.WriteLine("Not a day of a week. Try another number");
                    break;

            }
        }
    }
}
