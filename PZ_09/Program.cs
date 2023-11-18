namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//вводимое выражение

            int result = 0;
            string currentNumber = "";
            char operation = '+';

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (Char.IsDigit(currentChar)) //условие для определения чисел
                {
                    currentNumber += currentChar;
                }
                else //условие для определения операции(+ или -)
                {
                    int number = int.Parse(currentNumber);
                    if (operation == '+')
                    {
                        result += number;
                    }
                    else if (operation == '-')
                    {
                        result -= number;
                    }
                    operation = currentChar;
                    currentNumber = "";
                }
            }
            // процесс вычисления
            int lastNumber = int.Parse(currentNumber);
            if (operation == '+')
            {
                result += lastNumber;
            }
            else if (operation == '-')
            {
                result -= lastNumber;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
    }
