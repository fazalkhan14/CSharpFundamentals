using System.Text;

namespace CSharpFundamentalsDemo
{
    public class StringBuilderDemo
    {
        public static void SBDemo()
        {
            StringBuilder name = new StringBuilder("Fazal");

            System.Console.WriteLine("Name - "+name);

            name.Append(" Khan");

            System.Console.WriteLine("Name with Surname - "+name);
        }
    }
}