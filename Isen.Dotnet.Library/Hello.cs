using System;

namespace Isen.Dotnet.Library
{
    //renvoie des salutations
   /* private static string _world = "Hello,  World";
    public static string _world
    {
        get { return _world}
        set { _world = value}
    } */
    
    public class Hello
    {
        public static string  World{get; set;} = "Hello, World";
        public static string greet(string name){

            var time = DateTime.Now.ToString("HH:mm");
            var oldMessage = String.Format(" Hello {0} it is {1}.", name, time);
            //String interpollation avec $
            var message = $"Hello {name}, it is {time}. ";
            return message;
        }

        //expression body avec =>
        //même symbole qu'une lambda expression
        public static string GreetUpper(string name) => greet(name.ToUpper());
        
    }
}
