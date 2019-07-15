using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Mock_Testing.Tests")]
namespace Mock_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            Console.WriteLine(program.Add(5,6));
        }

        internal int Add(int a,int b)
        {            
            return a + b;
        }
    }
}
