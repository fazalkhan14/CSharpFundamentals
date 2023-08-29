using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    public class AbstractDemoChild : AbstractDemo
    {
        public AbstractDemoChild()
        {

        }

        public AbstractDemoChild(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //An method can be sealed if you don't want it to be overridden 
        //in further child classes of current class
        public sealed override void Display()
        {
            System.Console.WriteLine($"(Abstract Demo)Id - {this.Id}, Name - {this.Name}");
        }
    }
}