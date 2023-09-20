using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("Задание 1:"); // выводит все значения диапазона от -25 до 25 с шагом 25
            int a = 25;
            for (int i = -25; i <= a; i+=25)
            {
                Console.WriteLine(i);
            }

            //задание 2
            Console.WriteLine("Задание 2:");// выводит последующие 5 букв после P
            char bykva = 'P';
            int n = 5;
            for(int i = 0; i<=n; i++)
            {
                Console.Write($"{bykva},");
                bykva++;
            }
            // Задание 3
            Console.WriteLine("\nЗадание 3:"); // выводит символ # 4 раза в 7 строках
            int n1 = 4;
            int m = 7;
            String b = "#";
            for(int i = 1; i<=m; i++)
            {
                for(int g = 0; g < n1; g++)
                {
                    Console.Write(b);
                }
                Console.WriteLine("\n");
            }

            // Задание 4
            Console.WriteLine("Задание 4:");
            int sum = 0;
            int vibor = 2;
            for(int i = 0; i <= 200; i++)// выводит числа кратные 2 в диапазоне от 0 до 200
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i},");
                    sum++;
                }
                else
                    continue;

            }
            Console.WriteLine($"\nКоличество кратных чисел: {sum}");

            // Задание 5
            Console.WriteLine("Задание 5:");
            for(int i = 3, j = 50; j - i >= 17; i++, j--)//увеличивает и уменьшает переменные i и j пока разница между ними не достигнет 17
            {
                Console.WriteLine($"int i = {i},int j = {j}");
            }
        }
    }
}