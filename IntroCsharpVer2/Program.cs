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
            Demonstration demo;

            // skapa ett objekt av klassen Demonstration
            demo = new Demonstration(); 

            // anropa metoden RunHelloWord() som finns i klassen Demonstration
            demo.RunHelloWorld();
            demo.RunVariable();
            demo.RunKeyboardInput();
            demo.RunIf();
            demo.RunIfElse();
            demo.RunWhileWithCounter();
            demo.RunFor();
            demo.RunWhileWithoutCounter();
            demo.RunArrayAndForEach();
            demo.RunCallMethod();
        }
    }
}