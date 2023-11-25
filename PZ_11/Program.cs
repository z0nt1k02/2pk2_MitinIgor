namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Введите основание треугольника");//ввод данных
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту треугольника");
                int h = int.Parse(Console.ReadLine());
                TriangleP(a, h); //использование метода
            }
            
            
        }
        public static double TriangleP(int a, int h) // метод
        {
            
            double c = Math.Sqrt(Math.Pow(a/2, 2) + Math.Pow(h,2)); // боковая сторона
            double z = c + c + a; //периметр
            Console.WriteLine($"Периметр треугольника: {Math.Round(z,2)}"); // вывод польщователю с округлением до двух знаков
            return z;
           


        }
    }
}