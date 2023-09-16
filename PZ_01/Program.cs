namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());// вводим переменную а
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());// вводим переменную b
            Console.WriteLine("Введите третье число");
            double c = Convert.ToDouble(Console.ReadLine());// вводим переменную c
            double d = 5 * Math.Atan(a);// первая часть выражения
            double e = 1.0 / 4.0 * Math.Cos(a);// вторая часть выражения 
            double z = a + 3 * Math.Abs(a - b) + Math.Pow(a, 2);// третья часть выражения
            double x = Math.Abs(a - b) * c + Math.Pow(a, 2);// третья часть выражения
            double h = (z / x);//решенная третья часть выражения
            double u = e * h;// умножение второй части на третью
            double v = d - u;// вычитание из первой части произведения второй и третьей части
            Console.WriteLine("Ответ: " + v);// вывод ответа
        }
    }
}