using System;

namespace IntroCsharpVer2
{
    class Program
    {
        // Programkörning startar här.
        // Den startar alltid med anrop av Main-metoden.
        static void Main(string[] args)
        {
            // demo är en variabel som kan innehålla ett objekt av klassen Solution
            Solution run;

            // skapa ett objekt av klassen Solution
            run = new Solution();


            // Ta bort kommentarstecknena (//) för att köra funktionen :)
            // 
            
             run.HejAda();
             run.AreaCalculator();
             run.InputConverter();
             run.Summering();
             run.GissaTalet();
             run.TvåTärningar();
             run.While();
             run.For();
             run.NewWhile();
             run.SpelTärning();
             run.ArrayAndForEach();
             run.MetodDefinition();
             run.Inköpslista();

        }
    }
}