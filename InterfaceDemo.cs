using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    public class InterfaceDemo : IDemoInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public InterfaceDemo()
        {

        }

        public InterfaceDemo(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void Display()
        {
            System.Console.WriteLine($"(Interface demo)Id - {this.Id}, Name - {this.Name}");
        }

        public int Add(int marks1, int marks2)
        {
            return marks1+marks2;
        }
    }
}