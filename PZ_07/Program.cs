namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// строки
            int m = int.Parse(Console.ReadLine());// столбцы
            Random rnd = new Random();
            int[,] array = new int[n, m];// матрица
            Console.WriteLine();
            List<int> arrayMin = new List<int>();//массив для хранения минимальных значений столбцов
            // заполнение массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int value = rnd.Next(0, 100);
                    array[i, j] = value;
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // минимуальные значения  столбцов
           
            int min = int.MaxValue;
            int index = 0;
            while (index < n)
            {
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < m; j++)
                    {
                        if (j == index)
                        {
                            if (array[i, j] < min)
                            {
                                min = array[i, j];
                            }
                        }
                    }

                }
                Console.WriteLine($"min: {min}");
                arrayMin.Add(min);
                index++;
                min = int.MaxValue;
            }

            // вывод максимального числа из минимальных
            int max = int.MinValue;
            
            for (int i = 0; i < arrayMin.Count; i++)
            {
                if (arrayMin[i] > max)
                {
                    max = arrayMin[i];
                }
            }
            Console.WriteLine($"Максимальное значение: {max}");

        }
    }
}
    