using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    public class Transport
    {
        public double Distance;//В километрах
        public double Price;
        public double Cost;
        public virtual double Costs()
        {
            Cost = Distance * 1000;
            return Cost;
        }
        public virtual double Prices()
        {
            Price = Cost + Cost * 0.1;
            return Price;
        }
        public virtual string Info()
        {
            Costs();
            Prices();
            return $"Себестоимость перевозки:{Cost}\nЦена перевозки{Price}";
        }
        public Transport(double distance)
        {
            Distance = distance;
            
            Console.WriteLine(Info());
        }
    }
}
