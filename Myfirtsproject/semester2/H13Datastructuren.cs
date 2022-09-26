using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Myfirtsproject.semester2
{
    internal class H13Datastructuren
    {
        //public static void ForeachLoops()
        //{
        //    List<string> boodschappen = new();
        //    Console.WriteLine("Wat voor boodschappen heb je nodig?  je hebt alleen 10 ietems om te kiezen.");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        var nodigboodschappen = Console.ReadLine();
        //        boodschappen.Add(nodigboodschappen);
        //    }

        //    foreach (string boodschap in boodschappen)
        //    {
        //        Console.WriteLine($"Niet vergeten: {boodschap}");
        //    }
        //}


        public static void key()
        {
            var custemers = new List<KeyValuePair<string, int>>();
            custemers.Add(new KeyValuePair<string, int>("Mohamed", 20));
            custemers.Add(new KeyValuePair<string, int>("Remon", 21));



            foreach (var item in custemers)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }

        //public static void Queue()
        //{
        //    //Array rij
        //    Queue<string> klanten = new Queue<string>();
        //    //Wat in de Array zit
        //    klanten.Enqueue("Roos");
        //    klanten.Enqueue("Piet");
        //    klanten.Enqueue("Ellen");
        //    klanten.Enqueue("Frank");


        //    Console.Write($"De huidge wachtrij is :");
        //    //Array laten lopen met het inhoud
        //    foreach (var klant in klanten)
        //    {
        //        Console.WriteLine($"{klant}");
        //    }
        //    //Het eerste item van de Array Met Dequeue
        //    Console.WriteLine($"We bedienen nu klant {klanten.Dequeue()}\n");
        //    klanten.Enqueue("Redouan");
        //    //Het volgende item laten lezen Met Peek
        //    Console.WriteLine($"De volgende klant is {klanten.Peek()}\n");
        //    Console.Write("De huidige wachtrij is : ");
        //    //Array laten loopen van wat er blijft 
        //    foreach (string klant in klanten)
        //    {
        //        Console.WriteLine($"{klant}");
        //    }
        //    Console.WriteLine($"We bedienen nu klant {klanten.Dequeue()}\n");
        //    Console.WriteLine($"De volgende klant is {klanten.Peek()}\n");
        //    Console.Write("De huidige wachtrij is : ");
        //    foreach (string klant in klanten)
        //    {
        //        Console.WriteLine($"{klant}");
        //    }
        //    Console.WriteLine($"We bedienen nu klant {klanten.Dequeue()}\n");
        //    Console.WriteLine($"De volgende klant is {klanten.Peek()}\n");
        //    Console.Write("De huidige wachtrij is : ");
        //    foreach (string klant in klanten)
        //    {
        //        Console.WriteLine($"{klant}");
        //    }
        //    Console.WriteLine($"We bedienen nu klant {klanten.Dequeue()}\n");
        //    Console.WriteLine($"De volgende klant is {klanten.Peek()}\n");
        //    Console.Write("De huidige wachtrij is : ");
        //    foreach (string klant in klanten)
        //    {
        //        Console.WriteLine($"{klant}");
        //    }
        //    Console.WriteLine($"We bedienen nu klant {klanten.Dequeue()}\n");


        //    foreach (string klant in klanten)
        //    {
        //        if (klant != null)
        //        {
        //            Console.Write("De huidige wachtrij is : ");
        //            Console.Write($"{klant}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Er zijn geen mensen meer op de wachtrij ");

        //        }


        //    }
        //}

        public static void UndoDemo()
        {
            Stack<string> acties = new Stack<string>();

            acties.Push("Voeg paragraaf toe");
            acties.Push("Zet tekst in vet");
            acties.Push("Haal stuk tekst weg");

            Console.WriteLine("De actiehistoriek is :");
            foreach (string actie in acties)
            {
                Console.WriteLine($"\t{actie}");
            }
            Console.WriteLine($"Maak ongedaan: {acties.Pop()}\n");
            acties.Push("Maak tekst groter.");
            Console.WriteLine($"Maak ongedaan: {acties.Pop()}\n");

            acties.Push("Maak tekst kleiner.");
            Console.WriteLine($"De meest recente actie was: {acties.Peek()}\n");
            acties.Push("Voeg tekst toe.");
            Console.WriteLine("De actiehistoriek is :");
            foreach (string actie in acties)
            {
                Console.WriteLine($"\t{actie}");
            }

        }




    }
}
