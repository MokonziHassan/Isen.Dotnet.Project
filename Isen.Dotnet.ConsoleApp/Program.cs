using System;
using Isen.Dotnet.Library;


namespace Isen.Dotnet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Hello.greet("Hassan");
            Console.WriteLine(result);
        }
    }
}
