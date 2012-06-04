using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz.Library;

namespace FizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            // first check to see if the arg count is valid
            if (args == null || args.Length < 2 || args.Length == 3 || args.Length > 4)
            {
                Console.WriteLine(Resources.InvalidNumberArgs);
                return;
            }
            else
            {
                int? curInput = 0, input1 = 0, input2 = 0;

                // get the first integer parameter value
                curInput = CheckIntegerInput(args[0]);
                if (curInput != null)
                    input1 = curInput;
                else
                {
                    Console.WriteLine(String.Format(Resources.InvalidArg, 1));
                    return;
                }

                // get the second integer parameter value
                curInput = CheckIntegerInput(args[1]);
                if (curInput != null)
                    input2 = curInput;
                else
                {
                    Console.WriteLine(String.Format(Resources.InvalidArg, 2));
                    return;
                }

                // warn the user that the first integer must be greater than the second or it will not return output
                if (input1 > input2)
                {
                    Console.WriteLine(Resources.InvalidIntCombo);
                    return;
                }

                // now that the integer parameters have been checked for validity, it's time to run the FizzBuzz method
                if (args.Length > 2)
                    PrintFizzBuzzResults(input1.GetValueOrDefault(0), input2.GetValueOrDefault(0), args[2], args[3]);
                else
                    PrintFizzBuzzResults(input1.GetValueOrDefault(0), input2.GetValueOrDefault(0));

                return;
            }
        }

        /// <summary>
        /// Print the results of the FizzBuzz method to the console.
        /// </summary>
        /// <param name="input1">integer input 1</param>
        /// <param name="input2">integer input 2</param>
        /// <param name="input3">string input 3 ("Fizz")</param>
        /// <param name="input4">string input 4 ("Buzz")</param>
        private static void PrintFizzBuzzResults(int input1, int input2, string input3 = "Fizz", string input4 = "Buzz")
        {
            PrintDigits pd = new PrintDigits();
            List<string> outList = pd.GetDigits(input1, input2, input3, input4);

            foreach (var s in outList)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// Prompt the user to enter an integer. Return the integer if it's valid, otherwise return null.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private static int? CheckIntegerInput(string input)
        {
            int numInput = 0;

            // check to see if they entered a valid integer
            bool successful = Int32.TryParse(input, out numInput);

            if (successful)
                return numInput;
            else
                return null;
        }
    }
}
