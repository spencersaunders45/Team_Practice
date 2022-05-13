using System;

namespace team_practice{
   class Program{
    //    initiallizing the variables
    private string name;

    public Program(string name){
        this.name = name;
    }
    public void Sayname(){
        Console.WriteLine($"Hello World, Hello {name}");
    }
   }
}