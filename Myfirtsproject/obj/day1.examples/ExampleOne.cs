using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.day1.examples
{
    internal class ExampleOne
    {

        //Input/Output: ReadLine/WriteLine
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welkom bij Micpoint");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Ik ben Mohamed Loul");
            Console.WriteLine("Wie ben jij");

            string UNaam;
            String Leeftijd;
            String Woonplaats;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;
            UNaam = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hey" + " " + UNaam);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hoe oud ben je " + " " + UNaam);


            Leeftijd = Console.ReadLine();
            Console.WriteLine("Waar woon je" + " " + UNaam);
            Woonplaats = Console.ReadLine();
            Console.WriteLine("Dank u wel \n" + "Klopt U gegevens \n" + "Naam:" + UNaam + " " + Leeftijd + "jaar oud " + "Woon in " + Woonplaats);

        }

       

    }
}
