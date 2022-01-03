﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Kordused
    {
        static int ArraySize(int min, int max)
        {
            Random rnd = new Random();
            int A = rnd.Next(min, max);
            return A;
        }

        public static int[] ArrayCreate(int A)//A это размер масива
        {
            int[] array = new int[A];
            int arv;
            for (int i = 0; i < A; i++)
            {
                try
                {
                    Console.WriteLine("Введите число");
                    arv = int.Parse(Console.ReadLine());
                    array[i] = arv;
                }
                catch (Exception)
                {
                    Console.WriteLine("Думай лучше.");
                }
            }
            return array;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //int size = ArraySize(1, 20);
            Console.WriteLine("Напишите размер массива:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            arr = ArrayCreate(size);
            int addition = 0;
            int product = 1;
            foreach (var item in arr)
            {
                Console.Write("{0,3}", item);
                addition += item;
                product = item * product;
            }
            double average = addition / size;
            Console.WriteLine();
            Console.WriteLine("Сложение: {0}, умножение: {1}, среднее: {2}", addition, product, average);

            Console.WriteLine();

            Console.WriteLine("Купи слона!");
            while (true)
            {
                Console.WriteLine("Напишите ответ:");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "slon")
                {
                    Console.WriteLine("С вас 1000 евро");
                    break;
                }
                else
                {
                    Console.WriteLine("Все так говорят, а вы возьмите и купите слона");
                }
            }

            Console.WriteLine();

            Random rnd = new Random();
            int x = rnd.Next(100);
            int count = 1;
            Console.WriteLine("Попробуйте угадать число от 0 до 100 за 5 попыток.");
            while (count <= 5)
            {
                int k = int.Parse(Console.ReadLine());
                if (x == k)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 6)
                    {
                        Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + x + "!");
                        break;
                    }
                    if (k < x)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (k > x)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    
                }
            }
            Console.ReadLine();

            string[] abc = new string[5] { "A", "B", "C", "D", "E" };

            int ind = ArraySize(0, 4);
            Console.WriteLine("Индекс: {1}, буква: {0}", abc[ind], ind);
            int j = 0;
            while (j != abc.Length)
            {
                Console.WriteLine(abc[j]);
                j++;
            }


            int A = ArraySize(3, 12); //ряды
            int E = ArraySize(3, 12); //столбцы
            int[,] table = new int[A, E];
            //int[,] table2 = new int[,] { };
            for (int i = 0; i < A; i++)
            {
                for (j = 0; j < E; j++)
                {
                    table[i, j] = ArraySize(-10, 10);
                }
            }
            for (int i = 0; i < A; i++)
            {
                for (j = 0; j < E; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}