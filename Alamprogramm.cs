using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Alamprogramm
    {
        public static int Korruta(int a, int b)
        {
            return a * b;
        }

        public static float Keskmine(float a, float b)
        {
            float kesk = (a + b) / 2;
                return kesk;
        }

        static char[] action = new char[4] { '+', '-', '*', '/' };
        public static void CalcMur(float a, float b, char oper)
        {
            float total = a / b;
            if (action.Contains(oper))
            {
                if (oper == '+')
                {
                    total = a + b;
                }
                else if (oper == '-')
                {
                    total = a - b;
                }
                else if (oper == '*')
                {
                    total = a * b;
                }
                else if (oper == '/')
                {
                    total = a / b;
                }
                int tot = (int)total;
                for (int i = 0; i < total; i++)
                {
                    Console.Write("Murr ");
                }
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int x = 5;
            Console.WriteLine("Введите число y: ");
            int y = int.Parse(Console.ReadLine());
            int z = Korruta(x, y);
            Console.WriteLine("{0}*{1}={2}", x, y, z);
            Console.WriteLine(Korruta(x, y));
            Console.ReadKey();
        }
    }
}
