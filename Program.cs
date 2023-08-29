using System;

namespace CSharpFundamentalsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Boxing 
            BoxingAndUnboxing.Boxing();
            //Unboxing
            BoxingAndUnboxing.Unboxing();

            //Enums
            EnumsDemo.Enums();

            //Nullable type
            NullableTypeDemo.NullableType();

            //Stringbuilder demo
            StringBuilderDemo.SBDemo();

            //Static Constructor
            StaticConstructor stc = new StaticConstructor("Fazal");
            System.Console.WriteLine($"(Static Constructor)Id - {StaticConstructor.id}, Name - {stc.Name}");

            //Structure
            StructuresDemo st = new StructuresDemo(101,"Fazal");
            st.DisplayStudentDetails();

            //Abstract class Demo
            AbstractDemoChild ab = new AbstractDemoChild(101, "Fazal");
            ab.Display();

            //Interface demo
            InterfaceDemo interfaceObj = new InterfaceDemo(101,"Fazal Khan");
            interfaceObj.Display();
            int totalMarks = interfaceObj.Add(75,87);
            System.Console.WriteLine("Total marks - "+totalMarks);
        }
    }
}