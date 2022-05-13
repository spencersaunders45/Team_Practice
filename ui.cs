using System;

namespace team_practice{
   class Ui{
    //    initiallizing the variables
    private string name;

    public Ui(string name){
        this.name = name;
    }
    public void Sayname(){
        Console.WriteLine($"Hello World, Hello {name}");
    }
   }
}