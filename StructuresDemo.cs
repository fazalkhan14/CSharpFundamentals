using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    //To have related data in one place
    //When there is no complex functionalities other then data access and storing
    public struct StructuresDemo
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public StructuresDemo(int id, string name)
        {
            this.StudentID = id;
            this.Name = name;
        }
        public void DisplayStudentDetails()
        {
            System.Console.WriteLine($"(Struct demo)Id - {this.StudentID}, Name - {this.Name}");
        }
    }
}