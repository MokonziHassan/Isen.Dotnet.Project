using System;
using Isen.Dotnet.Library;
using Isen.Dotnet.Library.Models.Implementation;
using Isen.Dotnet.Library.Repositories.InMemory;
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
            /*var me = new Person{
            FirstName = "Kassamba",
            LastName = "Hassan",
            BirthDate = new DateTime(1995,3,6),
            City = new City{ Name = "Ouagadougou"}
            };
            
            Console.WriteLine(me);*/
            var cityRepo = new InMemoryCityRepository();
            Console.WriteLine(cityRepo.Single(3));
            Console.WriteLine(cityRepo.Single("Toulon"));
            var allCities = cityRepo.GetAll();
            foreach (var c in allCities) Console.WriteLine(c);
        }
    }
}
