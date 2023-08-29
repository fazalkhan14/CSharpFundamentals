using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    public abstract class AbstractDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Display();

        public void DisplayName()
        {
            System.Console.WriteLine("Name - "+this.Name);
        }
    }
}