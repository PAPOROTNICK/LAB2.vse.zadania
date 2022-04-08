using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________пузырь___________________________");
            int[] mas = new int[10000];
            int temp;
            Random rmd = new Random();
            HashSet<int> known = new HashSet<int>();
            for (int j = 0; j < mas.Length; j++)
            {
                int newchisla;
                newchisla = rmd.Next(0, 10000);
                while (known.Contains(newchisla))
                {
                    newchisla = rmd.Next(0, 10000);
                }
                known.Add(newchisla);
                mas[j] = newchisla;

            }
            //начало сортировки
            long freq = Stopwatch.Frequency;
            Stopwatch puz = new Stopwatch();
            puz.Start();
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
            puz.Stop();
            double sec = (double)puz.ElapsedTicks / freq; //переводим такты в секунды
            Console.WriteLine($"Время в секундах {sec}");


            Console.WriteLine("_________________________смешивание___________________________");
            int[] mas2 = new int[10000];
            Random rmd2 = new Random();
            HashSet<int> known2 = new HashSet<int>();
            for (int j = 0; j < mas2.Length; j++)
            {
                int newchisla2;
                newchisla2 = rmd2.Next(0, 10000);
                while (known2.Contains(newchisla2))
                {
                    newchisla2 = rmd2.Next(0, 10000);
                }
                known2.Add(newchisla2);
                mas2[j] = newchisla2;
            }


            //начало сортировки
            long freg2 = Stopwatch.Frequency;
            Stopwatch c1 = new Stopwatch();
            c1.Start();
            int left = 0, //левая граница
             right = mas2.Length - 1, //правая граница
             count = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)  //Сдвигаем к концу массива "тяжелые элементы"
                {
                    count++;
                    if (mas2[i] > mas2[i + 1])
                    {
                        Swap(mas2, i, i + 1); //swap функция обмена

                    }
                }
                right--;// уменьшаем правую границу

                for (int i = right; i > left; i--) //Сдвигаем к началу массива "легкие элементы"
                {
                    count++;
                    if (mas2[i - 1] > mas2[i])
                    {
                        Swap(mas2, i - 1, i);//swap функция обмена

                    }
                }
                left++; // увеличиваем левую границу
            }



            /* Поменять элементы местами */
            static void Swap(int[] mas2, int i, int j) //swap функция обмена
            {
                int glass = mas2[i];
                mas2[i] = mas2[j];
                mas2[j] = glass;

            }

            c1.Stop();
            double sec2 = (double)c1.ElapsedTicks / freg2; //переводим такты в секунды
            Console.WriteLine($"Время в секундах {sec2}");

            Console.WriteLine("_________________________рассчестка___________________________");
            int[] mas3 = new int[10000];
            Random rmd3 = new Random();
            HashSet<int> known3 = new HashSet<int>();
            for (int j = 0; j < mas3.Length; j++)
            {
                int newchisla3;
                newchisla3 = rmd3.Next(0, 10000);
                while (known3.Contains(newchisla3))
                {
                    newchisla3 = rmd3.Next(0, 10000);
                }
                known3.Add(newchisla3);
                mas3[j] = newchisla3;
            }
            //начаор сортировки
            long freg3 = Stopwatch.Frequency;
            Stopwatch c2 = new Stopwatch();
            c2.Start();
            double gap = mas3.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < mas3.Length)
                {
                    int igap = i + (int)gap;
                    if (mas3[i] > mas3[igap])
                    {
                        int swap = mas3[i];
                        mas3[i] = mas3[igap];
                        mas3[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }

            }

            c2.Stop();
            double sec3 = (double)c2.ElapsedTicks / freg3; //переводим такты в секунды
            Console.WriteLine($"Время в секундах {sec3}");

            Console.WriteLine("_________________________сортировка выбором___________________________");
            int[] mas4 = new int[10000];
            Random rmd4 = new Random();
            HashSet<int> known4 = new HashSet<int>();
            for (int j = 0; j < mas4.Length; j++)
            {
                int newchisla4;
                newchisla4 = rmd4.Next(0, 10000);
                while (known4.Contains(newchisla4))
                {
                    newchisla4 = rmd4.Next(0, 10000);
                }
                known4.Add(newchisla4);
                mas4[j] = newchisla4;
            }
            //начало сортироовки
            long freg4 = Stopwatch.Frequency;
            Stopwatch c3 = new Stopwatch();
            c3.Start();

            for (int i = 0; i < mas4.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas4.Length; j++)
                {
                    if (mas4[j] < mas4[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp3 = mas[min];
                mas[min] = mas[i];
                mas[i] = temp3;
            }
            c3.Stop();
            double sec4 = (double)c3.ElapsedTicks / freg4; //переводим такты в секунды
            Console.WriteLine($"Время в секундах {sec4}");
            Console.WriteLine("_________________________сортировка слияние___________________________");
            int[] mas5 = new int[10000];
            Random rmd5 = new Random();
            HashSet<int> known5 = new HashSet<int>();
            for (int j = 0; j < mas5.Length; j++)
            {
                int newchisla5;
                newchisla5 = rmd5.Next(0, 10000);
                while (known5.Contains(newchisla5))
                {
                    newchisla5 = rmd5.Next(0, 10000);
                }
                known5.Add(newchisla5);
                mas5[j] = newchisla5;

            }
            // начало сортировки
            long freg5 = Stopwatch.Frequency;
            Stopwatch c4 = new Stopwatch();
            c4.Start();
            int x;
            int g;
            for (int i = 1; i < mas5.Length; i++)
            {
                x = mas5[i];
                g = i;
                while (g > 0 && mas5[g - 1] > x)
                {
                    Swap(mas5, g, g - 1);
                    g -= 1;
                }
                mas5[g] = x;
            }
            double sec5 = (double)c4.ElapsedTicks / freg5; //переводим такты в секунды
            Console.WriteLine($"Время в секундах {sec5}");
        }
    }
}







