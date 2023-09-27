using System.Security.Claims;

namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();//создание переменной для рандома
            int[] a = new int[10];// объявление массива
            for(int i = 0; i < a.Length; i++) // вывод массива чисел в диапазоне от -10 до 10
            {
                int Value = rnd.Next(-10, 10);
                a[i] = Value;
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++) // вывод реверсного массива без реверса последнего числа
            {
                if (i < 9)
                    Console.Write($"{a[i] * -1} ");
                else
                    Console.Write(a[i]);
            }
                    
        }
    }
}