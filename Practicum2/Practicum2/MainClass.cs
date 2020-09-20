using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum2
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            week1_OrderedArray_Testaanroepen();

            PerformanceTest.TestSortPerformance();
        }

        private static void week1_OrderedArray_Testaanroepen()
        {
            // >>>> Testaanroepen week 1 - Ordered Array <<<<

            // Testaanroep constructor:

            BubbleSortableNawArrayUnordered array = new BubbleSortableNawArrayUnordered(20);

            // Testaanroepen Add:

            array.Add(new NAW("Persoon 1", "Adres 1", "Woonplaats 1"));
            array.Add(new NAW("Persoon 2", "Adres 2", "Woonplaats 2"));
            array.Add(new NAW("Persona non grata", "Adres 3", "Woonplaats 3"));
            array.Add(new NAW("Persoon 4", "Adres 4", "Woonplaats 2"));
            array.Add(new NAW("Persoon 1", "Adres 5", "Woonplaats 1"));
            array.Add(new NAW("Persoon 2", "Adres 6", "Woonplaats 2"));
            array.Add(new NAW("Persona non grata", "Adres 7", "Woonplaats 3"));
            array.Add(new NAW("Persoon 2", "Adres 8", "Woonplaats 2"));
            array.Add(new NAW("Persoon 9", "Adres 9", "Woonplaats 1"));
            array.Add(new NAW("Persoon 10", "Adres 10", "Woonplaats 2"));

            System.Console.WriteLine("\n\nDe geordende array na initialisatie maar voor bewerkingen is:");
            array.Show();

            // Activeer onderstaande testaanroepen wanneer je de bijhorende methode hebt geimplementeerd door de commentaarhaken weg te halen.

            // Testaanroepen Find:


            //NAW gezochteNAW = new NAW("Persoon 4", "Adres 4", "Woonplaats 2");
            //NAW nietbestaandeNAW = new NAW("Onbekende Persoon", "Adres 3", "Woonplaats 1");

            //int gezochteNAWIndex = array.Find(gezochteNAW);
            //System.Console.WriteLine("\nPersoon 4 gevonden op index {0}:", gezochteNAWIndex);

            //int gezochteNAWIndex2 = array.Find(nietbestaandeNAW);
            //System.Console.WriteLine("\nOnbekende Persoon gevonden op index {0}:", gezochteNAWIndex2);


            // Testaanroep Update:
            Console.WriteLine("BUBBLE SORT");
            array.BubbleSortInverted();
            array.Show();

            Console.WriteLine("halt");
        }
    }
}
