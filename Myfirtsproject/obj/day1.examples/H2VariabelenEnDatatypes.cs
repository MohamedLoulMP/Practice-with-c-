using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.day1.examples
{
    internal class H2VariabelenEnDatatypes
    {
        //Oefening: H2-optellen
       public static void Optellen()
       {
           int EersteGetal;
           int TweedeGetal;
           Console.WriteLine("Type het eerste nummer ?");
           EersteGetal = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Type je tweede getal");
           TweedeGetal = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(EersteGetal + TweedeGetal);

        }

        public static void VerbruikWagen()
        {
            double AantalLiterVoorDeRit;
            double AantalLiterNaDeRit;
            double KilometerstandVoorDeRit;
            double KilometerstandNaDeRit;
            Console.WriteLine("Geef het aantal liter in de tank voor de rit");
            AantalLiterVoorDeRit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef het aantal liter in de tank na de rit");
            AantalLiterNaDeRit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de kilometerstand van je auto voor de rit");
            KilometerstandVoorDeRit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de kilometerstand van je auto na de rit");
            KilometerstandNaDeRit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(100 * (AantalLiterVoorDeRit - AantalLiterNaDeRit) / (KilometerstandNaDeRit - KilometerstandVoorDeRit)); 

        }
    }

}
