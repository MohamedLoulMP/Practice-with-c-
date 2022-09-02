using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.day1.examples
{
    internal class Arrays
    {
        /* public static void Start()
         {
             Console.WriteLine("Hoe veel items ga je kopen?");
             int aantalItems = Convert.ToInt32(Console.ReadLine());
             string lijstje = "";
             for (int i = 1; i <= aantalItems; i++)
             {
                 Console.WriteLine($"Wat is het {i}e item dat je nodig hebt?");
                 lijstje = $"{i} {Console.ReadLine()}";

             }
             Console.WriteLine($"{lijstje} en  ");

         }
        */


        /* public static void Array()
          {
              string[] ietms = new string[10];
              string totalIetems;
              Console.WriteLine("Geef de 10 ietems die je wilt kopen");
              for(int i =1; i<=ietms.Length; i++)
              {
                  ietms[i] = Console.ReadLine(); 
              }

          }
        */

        /* public static void leefTijden()
         {
             int[] leefTijden = { 20, 21, 25, 30 };
             int oudesteleeftijd = leefTijden.Min();
             Console.WriteLine(oudesteleeftijd);
         }
        */

        /* public static void IndexOf()
         {
             string[] items = { "Koffie" ,"Sukker","Thee"};
             Console.WriteLine("Wil je weten of iets al op je lijstje staat? Geef de naam van het item.");
             string item = Console.ReadLine();
             int index = Array.IndexOf(items, item);
             if(index >= 0)
             {
                 Console.WriteLine($"{item} staat op het lijsje met index {index}");
             }else
             {
                 Console.WriteLine("staat nog niet op het lijst ");
             }
         }
        */

        /*( public static void Prijzen()
         {
             string[] producten = { "Laptop", "Scherm", "Muis" };
             int[] prijzen = { 500, 200, 50 };
             Console.WriteLine("Van welk product wil je de prijs kennen?");
             string product = Console.ReadLine();
             int productIndex = Array.IndexOf(producten, product);
             if (productIndex < 0)
             {
                 Console.WriteLine("Het product is niet aanwezig");
             }
             else
             {
                 Console.WriteLine(prijzen [productIndex]);
             }

         }
        */

        public static void Test()
        {
            string[] teksten = new string[10];
            teksten[0] = "hallo wereld";
            for (int i = 0; i < teksten.Length; i++)
            {
                if (!(teksten[i] is null))
                {
                    Console.WriteLine(teksten[i].ToString());
                }
            }
        }

    }
}
