using System;

namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array[i] = new int[rnd.Next(3, 11)];
            Console.WriteLine("Вывод массива с рандомными значениями");
            Console.WriteLine("\n");
            Random rnd = new Random();
            string[][] array = new string[9][];
            string[][] array2 = new string[9][];
            string[] LastElements = new string[9];//для записи последний элементов
            string[] maxElements = new string[9];//массив для максимальных элементов каждой строки
            string[] FirstNum = new string[9];//массив для первых элементов каждой строки
            string max = "";//переменная для поиска максимального значения
            int maxCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new string[rnd.Next(7, 16)];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = RandomString(rnd.Next(2, 6));
                    Console.Write(array[i][j] + " ");

                    if (array[i][j].Length >= maxCount)
                    {
                        maxCount = array[i][j].Length;
                        max = array[i][j];
                    }
                    //запись первого элемента каждой строки в массив
                    if (j == 0)
                    {
                        FirstNum[i] = array[i][j];
                    }
                }
                maxElements[i] = max;
                max = " ";
                //поиск последних элементов
                LastElements[i] = array[i][array[i].Length - 1];
                Console.WriteLine();
            }
            //создание метода для рандомного заполнения массива строками(сделано через нейросеть)
            string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                Random Random = new Random();
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[rnd.Next(s.Length)]).ToArray());
            }
            //создание такого же массива с теми же данными

            Console.WriteLine("\n");
            Console.WriteLine("Последние элементы каждого массива: ");
            //вывод последних элементов
            foreach (string s in LastElements)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            //вывод максимальных элементов
            Console.WriteLine("\n");
            Console.WriteLine("Максимальные элементы каждого массива: ");
            foreach (string g in maxElements)
            {
                Console.Write(g + " ");
            }
            Console.WriteLine();
            array2 = array;
            //Замена первых элементов каждого массива максимальными числами  
            Console.WriteLine("\n");
            Console.WriteLine("Замена первых элементов каждого массива максимальными числами");
            int forFirst = 0;
            int forMax = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2[i].Length; j++)
                {
                    if (array2[i][j] == FirstNum[forFirst])
                    {
                        array2[i][j] = maxElements[forFirst];
                    }
                    else if (array2[i][j] == maxElements[forMax])
                    {
                        array2[i][j] = FirstNum[forMax];
                    }
                    Console.Write(array2[i][j] + " ");
                }
                forFirst++;
                forMax++;
                Console.WriteLine();
            }
            //реверсаем массивы
            Console.WriteLine("\n");
            Console.WriteLine("Реверс массива");
            for (int i = 0; i < array2.Length; i++)
            {
                Array.Reverse(array2[i]);
                Console.WriteLine(String.Join(" ", array2[i]));
            }
            Console.WriteLine("Общее количество символов в строках каждой строки массива");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i].Length + " ");
            }





        }
    }
}