using System;

namespace team_practice{
   class Program
   {
      private static HelloWorld _helloWorld = new HelloWorld();
      static void Main(string[] args){
         _helloWorld.SayHelloWorld();
         Person person = new Person("spencer", 27);
         Console.WriteLine("Hello World");
         Console.WriteLine("Hello World");
         Console.Write("what is your name? : ");
         string myName = Console.ReadLine();
         Console.WriteLine("My name is Juno");
      }
   }
}