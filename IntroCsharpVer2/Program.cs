using System;

namespace IntroCsharpVer2
{
    class Program
    {
        // Programkörning startar här.
        // Den startar alltid med anrop av Main-metoden.
        static void Main(string[] args)
        {
            // demo är en variabel som kan innehålla ett objekt av klassen Demonstration
            Solution run;

            // skapa ett objekt av klassen Demonstration
            run = new Solution();

            // anropa metoden RunHelloWord() som finns i klassen Demonstration
            // run.RunHelloWorld();
            // run.RunVariable();
            // run.RunKeyboardInput();
            // run.RunIf();
            // run.RunIfElse();
            // run.RunWhileWithCounter();
            // run.RunFor();
            // run.RunWhileWithoutCounter();
            // run.RunSpelTärning();
            // run.RunArrayAndForEach();
            // run.RunMetodDefinition();
             run.Inköpslista();

        }
    }
}