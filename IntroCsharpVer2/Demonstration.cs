using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCsharpVer2
{
   
    /// <summary>
    /// Demonstrera grunder i C#. 
    /// 
    /// Innehåll:
    /// utskrift till konsoll
    /// if-sats
    /// inläsning från tangentbord
    /// while-slinga
    /// for-slinga
    /// vektor (eng. array)
    /// foreach-slinga
    /// metodanrop
    /// metoddefinition
    /// 
    /// Version: 2021-08-17
    /// Author: Rikard Karlsson
    /// </summary>
    class Demonstration
    {
        // konstruktorn anropas när ett objekt av klassen skapas
        public Demonstration()
        {

        }

        // att lära: skriva ut text
        // ---------------------------
        public void RunHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
        }


        // att lära: varaibler
        // --------------------
        // datatyp variabelnamn;
        // variabelnamn = värde;
        //
        // viktigaste datatyperna:
        // int - heltal
        // double - decimaltal
        // String eller string - text
        // char - en bokstav
        // bool - true, false
        public void RunVariable()
        {
            // rektangel
            double bredd = 20;
            double höjd = 30;
            double area;
            area = bredd * höjd;
            Console.WriteLine("rektangel");
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
        }

        // att lära: inmatning från tangentbordet
        // -----------------------------------
        public void RunKeyboardInput()
        {

            Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();
            Console.WriteLine("Välkommen " + namn + "!");
            Console.WriteLine();
        }
        

        // att lära: if-sats
        // ----------------------
        public void RunIf()
        {
            // kasta tärning - du behöver inte förstå nästa kodrad nu
            Random randomGenerator = new Random();
            int antalTärningsögon = randomGenerator.Next(1, 7);

            Console.WriteLine("Det kostar en krona att spela tärning. Sexor ger vinst.");
            Console.WriteLine("Tärningen visar: " + antalTärningsögon);

            if (antalTärningsögon == 6)
            {
                Console.WriteLine("Grattis du vann 5kr.");
            }
            else
            {
                Console.WriteLine("Förlust.");
            }

            Console.WriteLine();
        }
            
        public void RunIfElse()
        {
            // kasta tärning - du behöver inte förstå nästa kodrad nu
            Random randomGenerator = new Random();
            int antalTärningsögon = randomGenerator.Next(1, 7);
            // att lära: if med else if
            // ---------------------------
            // kasta tärning - du behöver inte förstå nästa kodrad nu
            antalTärningsögon = randomGenerator.Next(1, 7);

            Console.WriteLine("Det kostar en krona att spela tärning.");
            Console.WriteLine("Sexor ger storvinst och ettor tröstpris.");
            Console.WriteLine("Tärningen visar: " + antalTärningsögon);

            if (antalTärningsögon == 6)
            {
                Console.WriteLine("Grattis du vann 4kr.");
            }
            else if (antalTärningsögon == 1)
            {
                Console.WriteLine("Grattis du vann 1kr.");
            }
            else
            {
                Console.WriteLine("Förlust.");
            }
            Console.WriteLine();

        }

        // att lära: while med räkare
        // --------------------
        public void RunWhileWithCounter()
        {
            int räknare = 0;
            while (räknare < 5)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 1;
            }
            Console.WriteLine();
        }

        // att lära: for-slinga
        // -----------------------
        // Ger samma utskrift som while-slingan ovan.
        public void RunFor()
        {
            // ofta döps variabeln till i istället för räknare
            for(int räknare = 0; räknare < 5; räknare = räknare + 1)
            {
                Console.WriteLine("" + räknare);
            }
        }


        // att lära: while utan räknare
        // -----------------------------
        public void RunWhileWithoutCounter()
        {
            String input = "j";
            while (input.Equals("j")) // eller while ( input == "j")
            {
                Console.WriteLine("Gör något viktigt! ...");
                Console.WriteLine("Vill du fortsätta? j/n");
                input = Console.ReadLine();
            }
            Console.WriteLine("Klart!");
            Console.WriteLine();
        }


        // att lära: vektorer (eng. array)
        // -------------------------------
        // Kallas för fält av vissa författare.
        public void RunArrayAndForEach()
        {
            String[] lista = { "mjölk", "ost", "bröd" };
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine();

            int[] tal = new int[5];
            tal[0] = 4;
            tal[1] = 1;
            tal[2] = 3;
            tal[3] = 4;
            tal[4] = 6;

            // Att lära: foreach-slinga
            // ------------------------
            foreach (int talet in tal)
            {
                Console.Write(talet + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        




        // Att lära: anropa metoder
        // ------------------------
        
        public void RunCallMethod()
        {
            // anrop av metoden printHello
            // metoden finns definierad längre ner
            printHello();

            // Att lära:
            // anrop av metoden print som tar en parameter
            // Texten som ska skrivas ut skickas med, som en så kallad parameter.
            // Metoden print finns definierad längre ner
            // ----------------------
            print("Anrop av metoden print.");
            print("");

            int x = 0;
            // skriv ut text
            Console.WriteLine("x f(x) = 2x + 1");
            while (x < 6)
            {
                // Att lära:
                // anropa metoden f som tar en parameter och ger ett svar
                // ----------------------
                double svar = f(x);
                Console.WriteLine(x + " " + svar);
                x = x + 1;
            }
            Console.WriteLine();

            Console.WriteLine("Tryck tangent för att avsluta.");
            Console.Read();
        }
        
        // Att lära: definera metod
        // ---------------------------
        // Det som står i metoden görs när den anropas
        // private void printHello() kallas metodhuvud
        private void printHello()
        {
            // innehållet i metoden kallas för metodkropp
            Console.WriteLine("Hej och välkommen till C#.");
            Console.WriteLine();
        }

        // Att lära: definiera metod som tar parameter.
        // --------------------------------------------
        // Texten som måste skickas med vid anropet kallas parameter.
        private void print(String text)
        {
            Console.WriteLine(text);
        }

        // Att lära: definiera metoder med returvärde och parameter
        // --------------------------------------------------------
        // Svaret som lämnas tillbaka kallas för returvärde.
        private double f(double value)
        {
            return 2 * value + 1;
            // eller byt raden ovan mot:
            // double svar = 2 * value + 1;
            // return svar;
        }
    }
}
