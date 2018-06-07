using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeihnachtsbaumSchleife
{
    class Weihnachtsbaum
    {
        static void Main(string[] args)
        {
            int hoehe;

            Console.WriteLine("Wie hoch soll der Baum sein?");
            hoehe = Convert.ToInt32(Console.ReadLine());

            for (int i = hoehe; i > 0; i--) {
                
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i*2; k <= (hoehe*2+1); k++) {
                    Console.Write("x");
                }

                Console.WriteLine();
            }

            for (int i = hoehe; i > 0; i--)
            {
                Console.Write(" ");
            }
            Console.Write("xx");

            Console.ReadKey();
        }
    
    }
}
    
