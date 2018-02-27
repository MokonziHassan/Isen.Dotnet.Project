using System;

namespace Isen.Dotnet.Library
{
    //renvoie des salutations
    public class Hello
    {
        public static string greet(string name){
            string message = "Hello, " + name;
            return message;
        }
    }
}
