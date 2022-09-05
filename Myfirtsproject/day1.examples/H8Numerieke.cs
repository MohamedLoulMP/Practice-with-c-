using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.day1.examples
{
    internal class H8Numerieke
    {
        /*public static void EvenOneven()
        {
            int getal = 1234234;
            int rest = getal % 2;
            Console.WriteLine($"Indien het getal als rest 0 geeft weten we dat het even is. De rest is: {rest}");

        }
        */

        /* public static void RestBijDeling()
         {
             int getal = 5;
             int result = getal * getal * getal;
             return result = Math.Pow(getal, 3);


         }
        */

        /* public static void MathO(double x, double y)
         {
             double result = Math.Pow(x, y);
             Console.WriteLine(result);
         }
        */
        public static void RandomGetal()
        {
            Random mygen = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(mygen.Next(0, 20));
            }

        }


    }
}
