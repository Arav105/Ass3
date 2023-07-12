using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONVERTING STRING INTO INTEGER!!!
            /**  string str = "123";
              int number;

              if (int.TryParse(str, out number))
              {
                  Console.WriteLine("The integer value is: {0}", number);
              }
              else
              {
                  Console.WriteLine("The string could not be converted to an integer.");
              }
              Console.ReadKey();**/



            //CONVERTING STRING INTO DOUBLE!!!!
            /**string str = "abc";
            double num;
            bool success = double.TryParse(str, out num);
            if (success)
            {
                Console.WriteLine("The given input is converted to double :" + num);
            }
            else
            {
                Console.WriteLine("The given input cannot be converted into double!!!!");
            }
            Console.ReadKey();**/


            //CONVERTING STRING INTO DECIMAL!!!!
            Console.Write("Enter a decimal number: ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal number))
            {
                Console.WriteLine("The given input is converted into Decimal value: " + number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
            }
            Console.ReadKey();

        }

    }
}

