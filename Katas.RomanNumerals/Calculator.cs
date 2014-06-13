using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.RomanNumerals
{
    public static class Calculator
    {
        public static string Convert(int number)
        {
            var resultBuilder = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                resultBuilder.Append("I");
            }

            return resultBuilder.ToString();
        }
    }
}
