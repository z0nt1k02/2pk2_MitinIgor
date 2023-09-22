namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double x = -2.5;
           
            while(x < 2)
            {
                x += 0.5;
                double y = -2.4 * Math.Pow(x, 2) + 5 * x - 3;
                Console.WriteLine($" x = {x} , y = {Math.Round(y,2)}");
            }
        }
    }
}