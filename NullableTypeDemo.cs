using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    public class NullableTypeDemo
    {
        public static void NullableType()
        {
            int? number1 = null;

            if(number1.HasValue)
            {
                System.Console.WriteLine("number 1 -"+number1);
            }
            else{
                System.Console.WriteLine("It is empty");
            }

            int? number2 = 10;

            if(number2.HasValue)
            {
                System.Console.WriteLine("number 2 -"+number2);
            }
            else{
                System.Console.WriteLine("It is empty");
            }
        }

    }
}