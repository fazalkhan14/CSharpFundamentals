using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    public class StaticConstructor
    {
        public static int id { get; set; }
        public string Name { get; set; }

            //Static Constructor
        //Can't have access specifier's
        //Can't have paramters
        //Can't be accessed
        //Automatically called when class name is used
        static StaticConstructor()
        {
            id = 101;
        }
        public StaticConstructor()
        {
        }
        public StaticConstructor(string name)
        {
            this.Name = name;
        }
    }
}