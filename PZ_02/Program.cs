using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double x = 0;
            double z = 0;
           

                if (e > 9)
                {
                     x = e - (a / (11 * (e * Math.Pow(a, 2))));
                }
                else
                {
                     x = Math.Cos(e - 3);
                }
                if (x <= 0)
                {
                     z = Math.Sin(Math.Sqrt(e - 1.3 * a));
                }
                else
                {
                     z = Math.Pow(Math.Log(x, 10), 2) / Math.Sqrt(Math.Pow(x, 2) + 10);
                }
            

            double r = Math.Pow(z, 2) + x - a * e * x;
            Console.WriteLine(r);

        }
    }
}