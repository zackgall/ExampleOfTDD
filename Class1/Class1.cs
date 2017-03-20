using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RomanNumerals
{
    public class RomanConverter
    {
        public string GetRoman(int number)
        {
            string result = "";
            while (number >= 100)
            {
                result += "C";
                number -= 100;
            }
            if (number >= 90)
            {
                result += "XC";
                number -= 90;
            }
            if (number >= 50)
            {
                result += "L";
                number -= 50;
            }
            if (number >= 40)
            {
                result += "XL";
                number -= 40;
            }
            while (number >= 10)
            {
                result += "X";
                number -= 10;
            }
            if (number >= 9)
            {
                result += "IX";
                number -= 9;
            }
            if (number >= 5)
            {
                result += "V";
                number -= 5;
            }
            if (number >= 4)
            {
                result += "IV";
                number -= 4;
            }
            while (number > 0)
            {
                result += "I";
                number -= 1;
            }
            return result;
        }
    }
}
