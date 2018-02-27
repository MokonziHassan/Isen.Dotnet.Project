using System;
using Isen.Dotnet.Library;


namespace Isen.Dotnet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = Hello.World;
            Console.WriteLine(world);
            string result = Hello.greet("Hassan");
            Console.WriteLine(result);
        }
    }
}
