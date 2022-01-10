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

            Console.WriteLine("Введите первый символ:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак действия:");
            char oper = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй символ:");
            float b = float.Parse(Console.ReadLine());

            Alamprogramm.CalcMur(a, b, oper);
            Console.WriteLine();

            Console.WriteLine(Alamprogramm.Korruta(4, 5));
            Console.WriteLine(Alamprogramm.Keskmine(4, 5));

            Console.WriteLine("Welcome");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name.ToUpper());

            if (name.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno, {0}. Kui vana sa oled?", name);
                int vanus = int.Parse(Console.ReadLine());
                double hind = 6.50;
                string pilet;
                if (vanus < 0 || vanus > 120)
                {
                    Console.WriteLine("Viga!");
                }
                else
                { 
                    if (vanus < 6)
                    {
                        pilet = ("Suur sodus");
                        hind *= 0.5;
                    }
                    else
                    {
                        pilet = ("Täispilet");
                    }
                    Console.WriteLine("Sul on {0} pileti hind on {1}", pilet, hind);
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

            /*char sym = Console.ReadKey().KeyChar; - Моментальный ввод символа (Не требует Enter)*/
        }
    }
}
