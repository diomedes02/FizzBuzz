using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Library
{
    public class PrintDigits
    {
        public PrintDigits() { }

        /// <summary>
        /// Iterates through start and end integers and returns the iterations to a list of strings.
        /// Outputs the first string parameter on iterations divisible by 3 and the second on iterations divisible by 5.
        /// </summary>
        /// <param name="start">Beginning integer</param>
        /// <param name="end">Ending integer</param>
        /// <param name="strDiv3">String to print when the current interation number is divisible by 3.</param>
        /// <param name="strDiv5">String to print when the current interation number is divisible by 5.</param>
        /// <returns></returns>
        public List<string> GetDigits(int start, int end, string strDiv3, string strDiv5)
        {
            List<string> lst = new List<string>();

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    lst.Add(strDiv3 + strDiv5);
                else if (i % 3 == 0)
                    lst.Add(strDiv3);
                else if (i % 5 == 0)
                    lst.Add(strDiv5);
                else
                    lst.Add(i.ToString());
            }

            return lst;
        }
    }
}
