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
            var romanNumeral = "I";

            if (number.IsBetween(1,3))
            {
                romanNumeral = "I";
                int repeatCharacter = number > 3 ? 3 : number;


                for (int i = 0; i < repeatCharacter; i++)
                {
                    resultBuilder.Append(romanNumeral);
                }
            }
            if (number == 4)
            {
                return "IV";
            }
            if (number == 5)
            {
                return "V";
            }
            
            

            return resultBuilder.ToString();
        }
    }

    public static class IntegerExtensions
    {
        public static bool IsBetween(this int compareTo, int leftSide, int rightSide)
        {
            return (compareTo >= leftSide && compareTo <= rightSide);
        }
    }
}
