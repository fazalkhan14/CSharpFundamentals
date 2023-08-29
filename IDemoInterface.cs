using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    interface IDemoInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        void Display();
        int Add(int marks1,int marks2);
    }
}