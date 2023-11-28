namespace PZ_12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//определение размерности геометрической прогрессии
            GeomProg(n);// использование метода
        }
        public static double[] GeomProg(int n)//метод геометрической прогрессии
        {
            double[] result = new double[n];//создание массива членов геометрической прогрессии
            for (int i = 0; i < n; i++)//цикл для заполнения массива 
            {
                result[i] = 10 * Math.Pow(2, i);//вычисление каждого элемента прогрессии
                Console.Write(result[i] + " ");//вывод членов прогрессии
            }
            return result;
        }
    }
}