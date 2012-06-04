using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Library
{
    public static class PrintDigits
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start">Beginning integer</param>
        /// <param name="end">Ending integer</param>
        /// <param name="strDiv3">String to print when the current interation number is divisible by 3.</param>
        /// <param name="strDiv5">String to print when the current interation number is divisible by 5.</param>
        /// <returns></returns>
        public static List<string> GetDigits(int start, int end, string strDiv3, string strDiv5)
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
