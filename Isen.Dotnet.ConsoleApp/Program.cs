using System;
using Isen.Dotnet.Library;
using Isen.Dotnet.Library.Models.Implementation;

namespace Isen.Dotnet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var world = Hello.World;
            Console.WriteLine(world);
            string result = Hello.greet("Hassan");
            Console.WriteLine(result);*/
            var me = new Person{
            FirstName = "Kassamba",
            LastName = "Hassan",
            BirthDate = new DateTime(1995,3,6),
            City = new City{ Name = "Ouagadougou"}
            };
            
            Console.WriteLine(me);
        }
    }
}
