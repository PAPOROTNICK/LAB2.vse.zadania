using System;
using System.Collections.Generic;
namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину массива");
            int vvodMas = int.Parse(Console.ReadLine());
            object[,] mas = new object[4, vvodMas];//создаем массив
            List<int> listmas = new List<int>();//создаем коллекцию

            for (int i = 0; i < vvodMas; i++) //заполняем его от нуля до укащаного масива и  добавляем его в коллекцию
            {
                listmas.Add(i);
            }
            Console.WriteLine("объекты");//ввыводим числа
            foreach (int i in listmas)
            {
                Console.Write(i);
            }
            Stack<int> stakmas = new(listmas);//создаем стек для будущего использования и переденм данные с листа


            Console.WriteLine(" ");//без нее надпись "впереди стоящие будет на одной строке где и обекты"
            Console.WriteLine("______впереди стоящие__________");

            foreach (int i in listmas)
            {
                if (i < stakmas.Count - 1)
                {
                    mas[1, i] = i + 1;
                }
                Console.Write(mas[1, i]);
            }


            Console.WriteLine(" ");//тут тоже. 
            Console.WriteLine("______позади стоящие__________");

            foreach (int i in listmas)
            {

                if (i != 0 && i > 0 && i != listmas.Count)
                {
                    mas[2, i] = i - 1;
                }
                Console.Write(mas[2, i]);
            }

            Console.WriteLine(" ");//и тут
            Console.WriteLine("______стоящие объекты__________");
            for (int i = 0; i < listmas.Count; i++)//связи с объектами
            {
                int t = 1;
                int p = 0;
                if (i != listmas.Count)
                {
                    p = i + 1;
                }
                string test = "";
                if (p == vvodMas)
                {
                    break;
                }

                test = $"обьект:{i}стоит передобъектом:{p} ";
                Console.WriteLine(test);


            }
            Console.WriteLine("1:изменить связь на множественную");//выбор связи 
            Console.WriteLine("2:изменить связь к одному");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    for (int i = 0; i < listmas.Count; i++) //множесвенная связь
                    {
                        int fis = i;
                        int sec = i + 1;
                        int three = i - 1;
                        string ts = "";
                        if (fis == 0)
                        {
                            mas[3, 0] = ts;
                        }
                        else
                        {
                            string ts2 = "";
                            ts2 = $"объект: {fis} Стоит: {three}, после{sec}";
                            mas[3, i] = ts2;
                        }
                    }
                    for (int j = 0; j < vvodMas - 1; j++)
                    {
                        Console.WriteLine(mas[3, j]);
                    }

                    break;
                case 2:
                    for (int i = 0; i < listmas.Count; i++)
                    {
                        int t = i;
                        int p = 0;//стоящий врепеди элемнт
                        if (i != listmas.Count)
                        {
                            p = i + 1;
                        }
                        string ts2 = "";
                        ts2 = $"объект: {i} Стоит перед объектом: {p}";//сборка всего
                        mas[3, i] = ts2;
                    }
                    for (int j = 0; j < vvodMas - 1; j++)
                    {
                        Console.WriteLine(mas[3, j]);
                    }
                    break;

            }

        }
    }

}












