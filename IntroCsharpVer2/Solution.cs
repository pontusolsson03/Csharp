﻿using System;
using System.Runtime.InteropServices;

namespace IntroCsharpVer2
{
    class Solution
    {

        public void HejAda()
        {
            Console.WriteLine("Hej Ada. Varmt välkommen.");
            Console.WriteLine();
        }



        public void AreaCalculator()
        {
            double bredd = 9.6;
            double höjd = 5.4;
            double area = bredd * höjd;
            Console.WriteLine("Bredden är " + bredd);
            Console.WriteLine("Höjden är " + höjd);
            Console.WriteLine("Det gör att arean blir " + area);
            Console.WriteLine();

        }



        public void InputConverter()
        {
            Console.WriteLine("Vad är bredden på rektangeln?");
            string breddString = Console.ReadLine();
            double breddDecimal = Convert.ToDouble(breddString);

            Console.WriteLine("Vad är höjden på rektangeln?");
            string höjdString = Console.ReadLine();
            double höjdDecimal = Convert.ToDouble(höjdString);

            double area = breddDecimal * höjdDecimal;

            Console.WriteLine("Bredden är " + breddDecimal);
            Console.WriteLine("Höjden är " + höjdDecimal);
            Console.WriteLine("Arean är " + area);
            Console.WriteLine();
        }



        public void Summering()
        {
            Console.WriteLine("Var vänlig skriv ditt första tal nu:");
            string firstString = Console.ReadLine();
            double firstDouble = Convert.ToDouble(firstString);

            Console.WriteLine("Var vänlig skriv ditt andra tal nu:");
            string secondString = Console.ReadLine();
            double secondDouble = Convert.ToDouble(secondString);

            double summary = firstDouble + secondDouble;

            Console.WriteLine("Summan av dina två tal är " + summary);
            Console.WriteLine();

        }



        public void GissaTalet()
        {
            Console.WriteLine("Gissa mitt favorittal!");
            string gissning = Console.ReadLine();
            double gissningDouble = Convert.ToDouble(gissning);

            if (gissningDouble == 3)
            {
                Console.WriteLine("Du gissade rätt!");
            }

            else
            {
                Console.WriteLine("Du gissade fel.");
            }
            Console.WriteLine();
        }



        public void TvåTärningar()
        {
            Random random = new Random();
            int tärningEtt = random.Next(1, 6);
            int tärningTvå = random.Next(1, 6);

            Console.WriteLine("Vi kastar tärningen två gånger. Om det blir samma båda gångerna vinner du.");
            Console.WriteLine("Första gången blev det " + tärningEtt);
            Console.WriteLine("Andra gången blev det " + tärningTvå);

            if (tärningEtt == tärningTvå)
            {
                Console.WriteLine("Det blev samma, så du vann!");
            }

            else
            {
                Console.WriteLine("Det blev inte samma, du förlorade.");
            }
            Console.WriteLine();
        }



        public void While()
        {
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;

            }

            Console.WriteLine();

            int o = 5;
            while (o < 21)
            {
                Console.WriteLine(o);
                o += 3;
            }

            Console.WriteLine();

            int p = 10;
            while (p > -1)
            {
                Console.WriteLine(p);
                p--;
            }

            Console.WriteLine();
        }



        public void For()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int o = 5; o < 21; o += 3)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();

            for (int p = 10; p > -1; p--)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
        }


        public void NewWhile()
        {

            Console.WriteLine("Gissa på ett nummer mellan 1 och 25!");

            string tal = Console.ReadLine();
            int talInt = Convert.ToInt32(tal);


            while (talInt != 15)
            {
                Console.WriteLine("Fel, försök igen!");
                tal = Console.ReadLine();
                talInt = Convert.ToInt32(tal);
            }

            Console.WriteLine("Rätt, du vann!");
            Console.WriteLine();

        }



        public void SpelTärning()
        {
            Console.WriteLine("Nu kastar vi två tärningar.");
            Console.WriteLine("Om båda blir sexor vinner du storvinst.");
            Console.WriteLine("Om de annars båda blir lika vinner du en lite vinst");
            Console.WriteLine("Om inga av dessa händer förlorar du.");
            Console.WriteLine("");

            Random random = new Random();
            int tärning1 = random.Next(1, 7);
            int tärning2 = random.Next(1, 7);

            Console.WriteLine("Tärningarna visar " + tärning1 + " och " + tärning2 + ".");
            Console.WriteLine("");

            if (tärning1 == 6 && tärning2 == 6)
            {
                Console.WriteLine("Grattis, storvinst!");
                Console.WriteLine("");
            }

            else if (tärning1 == tärning2 && tärning1 != 6)
            {
                Console.WriteLine("Grattis, liten vinst!");
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("Tyvärr, förslust.");
                Console.WriteLine();
            }
        }



        public void ArrayAndForEach()
        {
            
            int[] arr = { 3, 5, 7, 9, 11, 13 };
            int i = 0;

            foreach (int tal in arr)
            {
                Console.WriteLine(tal + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (int tal in arr)
            {
                arr[i] = arr[i] + 1;
                i++;
            }

            foreach (int tal in arr)
            {
                Console.WriteLine(tal + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }



        public void MetodDefinition()
        {
            Console.WriteLine("Välkommen agent X, ditt uppdrag är...");
            Console.WriteLine("Vänligen skriv tre tal: ");
            Console.WriteLine();

            string talEtt = Console.ReadLine();
            string talTvå = Console.ReadLine();
            string talTre = Console.ReadLine();
            int intEtt = Convert.ToInt32(talEtt);
            int intTvå = Convert.ToInt32(talTvå);
            int intTre = Convert.ToInt32(talTre);

            int summa = SummaCalc(intEtt, intTvå, intTre);
            Console.WriteLine("Summan av dina tre tal är...:");
            Console.WriteLine();
            Console.WriteLine(summa);
            Console.WriteLine();
            Console.WriteLine();
        }
        public int SummaCalc(int intEtt, int intTvå, int intTre)
        {
            int summa = intEtt + intTvå + intTre;
            return summa;
        }



        public void Inköpslista()
        {
            Console.WriteLine("Hallå där! Vad vill du att jag skriver upp på din inköpslista?");
            Console.WriteLine("När du inte har några fler saker du vill lägga till,");
            Console.WriteLine("skriv 'klar'.");
            Console.WriteLine();

            int i = 0;
            string[] listan = new string[1000];
            string varan = Console.ReadLine();

            while (varan != "klar")
            {
                listan[i] = varan;
                i++;
                varan = Console.ReadLine();
            }
           
            Console.WriteLine();
            foreach (string vara in listan)
            {
                if (vara != null)
                {
                    Console.WriteLine(vara);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
