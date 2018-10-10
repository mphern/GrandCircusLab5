using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num;
            string goAgain = "Y";
            Console.WriteLine("Welcome to the Factorial Calculator!");
            
            while (goAgain == "Y")
            {
                Console.WriteLine("\n");
                Console.Write("Please select an integer between 0 and 65: "); //65 is the highest number a ulong can handle
                while (!(ulong.TryParse(Console.ReadLine(), out num)) || num < 0 || num > 65)
                {
                    Console.Write("Invalid selection.  Please select an integer between 0 and 65: ");
                }

                Console.WriteLine("The factorial of " + num + " is " + GetFactorial(num));
                Console.WriteLine("\n");
                Console.Write("Would you like to do it again? Y/N: ");
                goAgain = Console.ReadLine().ToUpper();
                if (goAgain == "YES")
                    goAgain = "Y";
                if (goAgain == "NO")
                    goAgain = "N";
                while(goAgain != "Y" && goAgain != "N")
                {
                    Console.Write("Invalid selection. Would you like to do it again? Y/N: ");
                    goAgain = Console.ReadLine().ToUpper();
                    if (goAgain == "YES")
                        goAgain = "Y";
                    if (goAgain == "NO")
                        goAgain = "N";
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
        public static ulong GetFactorial(ulong number)
        {
            if(number == 0)
            { return 1; }  //The factorial of 0 is equal to 1
            else
            { return number * GetFactorial(number - 1); }
        }
    }
}
