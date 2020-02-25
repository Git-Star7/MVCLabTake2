using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab_Take_2.Models
{
    public class Maths
    {
        public static string Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result.ToString();
        }
        public static string Divide(int num1, int num2)
        {
            double divNum = num1 / num2;
            double divRemainder = num1 % num2;

            return $"{divNum} with a ramainder of {divRemainder}";
        }
    }
}
