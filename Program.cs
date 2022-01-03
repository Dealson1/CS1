using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Welcome");
            Console.WriteLine("Хай");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name.ToUpper());

            if (name.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno, {0}", name);
                int vanus = int.Parse(Console.ReadLine());
                double hind = 6.50;
                if (vanus < 0 || vanus > 120)
                {
                    Console.WriteLine("Viga!");
                }
                else if (vanus < 6)
                {
                    Console.WriteLine("Suur sodus");
                    hind *= 0.5;
                }
                else
                {
                    Console.WriteLine("Täispilet");
                }

            }
            else
            {
                Console.WriteLine("Mina olen hõivatud");
            }

            Console.ReadLine();
            /*int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);*/
        }
    }
}
