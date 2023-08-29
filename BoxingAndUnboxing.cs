using System;

namespace CSharpFundamentalsDemo
{
    public class BoxingAndUnboxing
    {
        public static void Boxing()
        {
            int number = 5;

            object num = number;

        }

        public static void Unboxing()
        {
            int number = 5;

            object num = number;

            int no = (int) num;
        }
    }
}