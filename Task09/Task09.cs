using System;
using Library_Task8;

namespace Task09
{
    class Task09
    {
        static void Main(string[] args)
        {
            /*SWITCH operatoru ile yoxla. 
              Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
              Eger bu eded 
			 	1 olarsa-"Yanvar" sozunu 
				2 olarsa-"Fevral" sozunu
				...
				12 olarsa-"Dekabr" sozunu yaz*/
            Console.WriteLine("use Switch operator. Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)");
            step:
            int anynumber = Library.CheckForDigits(" PLease anter any number:  ");
            switch (anynumber)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break; 
                case 2:
                    Console.WriteLine("February");
                    break; 
                case 3:
                    Console.WriteLine("Martch");
                    break; 
                case 4:
                    Console.WriteLine("April");
                    break; 
                case 5:
                    Console.WriteLine("May");
                    break; 
                case 6:
                    Console.WriteLine("June");
                    break; 
                case 7:
                    Console.WriteLine("July");
                    break; 
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break; 
                case 10:
                    Console.WriteLine("October");
                    break; 
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Given Number is not in Range from 1 to 12. Try Again");
                    goto step;


            }
        }
    }
}
