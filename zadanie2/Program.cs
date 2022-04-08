using System;
using System.Collections.Generic;
using System.Collections;
namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст");
            string text;
            text = Console.ReadLine();
            SortedList<int, char> data = new();
            int key = 0;
            foreach (char bucv in text)
            {
                if (data.ContainsValue(bucv) == false)
                {
                    data.Add(key, bucv);
                    key++;
                }
            }
            foreach (var v in data)
            {
                Console.WriteLine(v);
            }
            List<char> org = new();
            foreach (char s in text)
            {
                org.Add(s); // Выводим лист.
            }
            List<char> cop = new();
            foreach (char s in text)
            {
                cop.Add(s); // Выводим лист.
            }
            Console.WriteLine("выбор");
            Console.WriteLine("1:сортировка по возрастанию");
            Console.WriteLine("2:сортировка по убыванию");
            Console.WriteLine("3:количество каждого символа");
            Console.WriteLine("4:замена символа");
            int index = int.Parse(Console.ReadLine());
            switch (index)
            {



                case 1:
                    Console.WriteLine("___________сортировка по возрастанию______");
                    List<char> sov = new();
                    for (int i = 0; i < data.Count; i++) // Кол-во уникальных символов.
                    {
                        for (int j = 0; j < org.Count; j++) // Кол-во всех символов.
                        {
                            if (data[i] == org[j]) // Смотрим на уникальные символы начиная с нулевого элемента и сравниваем с каждым символом текста.
                            {
                                sov.Add(org[j]);
                            }
                        }
                    }
                    foreach (char a in sov)
                    {
                        Console.WriteLine(a);
                    }
                    break;
                case 2:
                    Console.WriteLine("___________сортировка по убыванию______");
                    List<char> sov2 = new();
                    for (int i = 0; i < data.Count; i++) // Кол-во уникальных символов.
                    {
                        for (int j = 0; j < org.Count; j++) // Кол-во всех символов.
                        {
                            if (data[i] == org[j]) // Смотрим на уникальные символы начиная с нулевого элемента и сравниваем с каждым символом текста.
                            {
                                sov2.Add(org[j]);
                            }
                        }
                    }

                    sov2.Reverse();
                    foreach (char b in sov2)
                    {
                        Console.WriteLine(b);
                    }
                    break;
                case 3:

                    Console.WriteLine("количество каждого символа");
                    for (int i = 0; i < data.Count; i++) // Кол-во уникальных символов.
                    {
                        int count = 0;
                        for (int j = 0; j < org.Count; j++) // Кол-во всех символов.
                        {
                            if (data[i] == org[j]) // Смотрим на символы и считаем их
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"[{data[i]}] - {count}");
                    }
                    Console.WriteLine($"Всего символов:{org.Count}");
                    Console.ReadKey();

                    break;

                case 4:
                    Console.WriteLine("какую букву ходите заменить");
                    char zam = char.Parse(Console.ReadLine());
                    Console.WriteLine("на что хотите заменить");
                    char zam2 = char.Parse(Console.ReadLine());




                    int count2 = 0;
                    for (int i = 0; i < cop.Count; i++)
                    {
                        if (zam == cop[i]) //ищем букву которую нужно заменить
                        {

                            cop[i] = zam2;//заменяем
                            count2++;//считаем
                        }

                    }
                    foreach (var v in cop)
                    {
                        Console.Write(v);
                    }

                    Console.WriteLine("количество замененого символа" + count2);


                    cop = org;
                    Console.WriteLine("5:ввернуться к оригиналу оригинал");
                    int h5 = int.Parse(Console.ReadLine());

                    if (h5 == 5)
                    {
                        goto case 5;
                    }


                    break;

                case 5:
                    org = cop;
                    foreach (var v in cop)
                    {
                        Console.Write(v);
                    }
                    break;
            }

        }
    }
}










