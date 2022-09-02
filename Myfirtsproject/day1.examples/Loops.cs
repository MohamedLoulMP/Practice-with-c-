using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.day1.examples
{
    internal class H5Loops
    {
        /*public static void CountDown()
        {
            int num = 0;
            Console.WriteLine("Geef een getal in : ");
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {

                Console.WriteLine(num);
                num = num -1;


            }
            Console.WriteLine("Start");

        } */


        /* static void Wachtwoord()
         {
             string PSW;
             int aantal;
             PSW = "AP";
             aantal = 0;
             do
             {
                 Console.WriteLine("Geef het wachtwoord in :");
                 PSW = Console.ReadLine();
                 aantal = aantal + 1;
             }
             while (PSW!= "AP");
             Console.WriteLine("Wacht woord in orde");
             Console.WriteLine("Aantal pogingen:" + aantal);

         }
        */

        /* public static void Feestje()
         {
             List<string> guests = new();



             Console.Write("Wil je een volgende persoon inschrijven? (ja of nee) ");
             var enterNextGuest = Console.ReadLine() == "ja";



             while (enterNextGuest && guests.Count < 20)
             {
                 Console.Write("Geef de naam: ");
                 var guest = Console.ReadLine();
                 guests.Add(guest);



                 Console.Write("Wil je een volgende persoon inschrijven? (ja of nee) ");
                 enterNextGuest = Console.ReadLine() == "ja";
             }



             var names = string.Join(" ", guests);
             Console.WriteLine($"Lijst van aanwezige personen: {names}");
             Console.WriteLine($"Er zijn {guests.Count()} personen aanwezig");

         }
        */

    }
}
