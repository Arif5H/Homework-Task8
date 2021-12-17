using System;
using Library_Task8;

namespace Task14
{
    class Tast14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)");
            Console.WriteLine(" Bu ededin evvelin 1 reqemini artir."); 
            step:
            double number = Library.CheckForDigits("Please enter number:  ");
            int counter = 10;
            try
            {
                if (number < 100000000)
                {
                    while (number < 100000000)
                    {
                        if (number < counter)
                        {
                            number = counter + number;
                            
                            throw new Exception($"1 Typed before number {number}");
                        }
                        counter *= 10;
                    }
                }
                else
                {
                    Console.WriteLine("Entered number has more than 8-digits");
                    goto step;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }


    }
}
