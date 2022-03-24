using System;
using dotnet___poo.src.Entities;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[]args)
        {
            knight arus = new knight("Arus", 23, "knight", 469, 72);
            Wizard wizard = new Wizard("Jennica", 23, "white wizard", 325, 474);
            Ninja ninja = new Ninja("Wedge", 23, "Ninja", 292, 89);
            Black topada = new Black("Topada", 23, "blackwizard", 106, 611);
            
             System.Console.WriteLine(wizard.Attack(1));
             System.Console.WriteLine(ninja.Attack());
             System.Console.WriteLine(wizard.Attack(7));
             System.Console.WriteLine(arus.Attack());
             System.Console.WriteLine(topada.Attack());
                                    
            
        }
    }
}
    

