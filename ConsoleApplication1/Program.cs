using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=22;  
            string msg = i % 2 == 0 ? "Entered Number is an Even Number" : "Entered Number is an Odd Number";            
            Console.Write(msg);
            Console.Read();                      
        }
    }
}
