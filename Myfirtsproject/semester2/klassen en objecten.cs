using Myfirtsproject.day1.examples;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.semester2
{
    internal class klassen_en_objecten
    {


        public static void klassen()
        {
            //Date time Now
            /* DateTime mo = DateTime.Now;
             Console.WriteLine(mo);
             DateTime birthday = new DateTime(2001, 01, 01); //year, month, day
             Console.WriteLine(birthday);
             DateTime SomeMoement = new DateTime(2001, 01, 01, 18, 30, 10);
             Console.WriteLine(SomeMoement);
            */

        }
        public static void Oefenen()
        {

            /* List<string> spellersNammen = new List<string>();

             Console.WriteLine("Wil je een volgende persoon inschrijven? (ja of nee)");
             var addNammSpellers = Console.ReadLine() == "ja";

             while (addNammSpellers && spellersNammen.Count < 5)
             {
                 Console.WriteLine("Voeg de namen");
                 var naam = Console.ReadLine();
                 spellersNammen.Add(naam);

                 Console.WriteLine("Wil je een volgende persoon inschrijven? (ja of nee)");
                 addNammSpellers = Console.ReadLine() == "ja";
             }

               */
        }

        public static void Date()
        {
            /* DateTime timenow = new DateTime(2001, 01, 01);
            DateTime nextwwek = timenow.AddYears(21);
            Console.WriteLine(nextwwek);

            */
        }

        public static void LocalizedTime()
        {
            /*  DateTime now = DateTime.Now;
              CultureInfo russianCI = new CultureInfo("ar-SY");
              Console.WriteLine($"Current time in Russian style is: {now.ToString("F", russianCI)}");
            */
        }
        public static void ParsingTime()
        {
            /* Console.WriteLine("Voeg hier een datum yy,manth,days");
             var date_string = Console.ReadLine();
             DateTime dt = DateTime.Parse(date_string);
             Console.WriteLine(dt);
            */
        }
        public static void IsLeapYear()
        {
            /*  DateTime today = DateTime.Now;
              bool isLeap = DateTime.IsLeapYear(today.Year);
              if(isLeap == true)
              {
                  Console.WriteLine("Thies is a leap year");
              }
            */
        }

        public static void TimeSpan()
        {
            /* Console.WriteLine("voeg het");
            DateTime today = DateTime.Today;
            DateTime geboordeDatum = new DateTime();
            geboordeDatum = DateTime.Parse(Console.ReadLine()); 
            TimeSpan aantalDagen = today - geboordeDatum;
            Console.WriteLine("{0} DAGEN ZIJN GEWEEST SINDS JIJ BENT GEBOOREN.", aantalDagen);
            */
        }

        /*public static void DagVanDeWeek()
        {
            string[] dagen = { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
            string[] namen = { "mandag" };
            int[] weekdays = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(dagen[0]);
        }
        */

      /*  public static void WeekdagProgramma()
        {

            Console.WriteLine("jaar");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("maand");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("dag");
            var day = int.Parse(Console.ReadLine());

            var dateTime = new DateTime(year, month, day);
            Console.WriteLine($"{dateTime:dd} {dateTime:MMMM} {dateTime:yyyy} is een vrij dag  ");

        }
      */

       /* public static void WeekdagProgrammaRemon()
        {
            Console.WriteLine("jaar");
            var year = Console.ReadLine();
            Console.WriteLine("maand");
            var month = Console.ReadLine();
            Console.WriteLine("dag");
            var day = Console.ReadLine();



            var dateString = $"{year}-{month}-{day}";



            if (DateTime.TryParse(dateString, out DateTime date))
            {
                Console.WriteLine($"{date:D} {date:dddd}");
            }
            else
            {
                Console.WriteLine("er is iets mis gegaan");
            }
        }
       */



        /* public static void Auto()

          {
              int aantalAutos = 3;
              int[] kilometers = new int[aantalAutos];
              double[] benzine = new double[aantalAutos];
              DateTime[] onderhoud = new DateTime[aantalAutos];

              for (int i = 0; i < aantalAutos; i++)
              {
                  Console.WriteLine($"kilometerstand van auto {i + 1}");
                  kilometers[i] = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine($"benzine van auto {i + 1}");
                  benzine[i] = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine($"Jaar recentste onderhoud auto {i + 1}?");
                  int jaar = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine($"Maand recentste onderhoud auto {i + 1}?");
                  int maand = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine($"Dag recentste onderhoud auto {i + 1}?");
                  int dag = Convert.ToInt32(Console.ReadLine());
                  onderhoud[i] = new DateTime(jaar, maand, dag);

              }


          }
        */




    }
}
