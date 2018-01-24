using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the factorial calcualtor.");
            GetUserInput();
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Please enter a integer between 1-170");
            bool bit = int.TryParse(Console.ReadLine(), out int userInput);

            if (bit && userInput > 0 && userInput <= 170)
                CalculateFactorial(userInput);
            else if (bit && userInput < 170)
                InputError("Any number greater than 170 is considered infinity.");
            else
                InputError("You have entered an invalid number. ");
        }

        private static void InputError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            QuitConsoleApp();
        }

        private static void CalculateFactorial(int userInput)
        {
            double factorial = userInput;
            for (int i = userInput - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            BuildResponse(factorial, userInput);
        }

        private static void BuildResponse(double factorial, int userInput)
        {
            Console.WriteLine(string.Format("The factorial of {0} is {1}.", userInput, factorial));
            QuitConsoleApp();
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
