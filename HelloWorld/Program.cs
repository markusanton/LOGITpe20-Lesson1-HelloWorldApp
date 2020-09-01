using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello, " + name);
        }
    }
}