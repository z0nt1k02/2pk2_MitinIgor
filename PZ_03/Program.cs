namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу фигуру:");
            string a = Console.ReadLine();
            switch (a)
            {
                case "Круг": Console.WriteLine("Введите радиус круга:");
                    double r = double.Parse(Console.ReadLine());
                    double Skr = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("Площадь круга: " + Math.Round(Skr, 2));
                    break;
                case "Квадрат": Console.WriteLine("Введите длину и ширину квадрата:");//Ввод данных квадрата
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    double Skv = x * y;
                    Console.WriteLine($"Площадь квадрата {Skv}");
                    break;
                case "Треугольник": Console.WriteLine("Введите длину высоты треугольника и длину стороны от которой вы проводите высоту");
                    double h = double.Parse(Console.ReadLine());    
                    double z = double.Parse(Console.ReadLine());
                    double Str = 0.5 * (h * z);
                    Console.WriteLine($"Площадь треугольника: {Str}");
                    break;
                default: Console.WriteLine("Фигура не определена");
                    break;


            }
        }
    }
}