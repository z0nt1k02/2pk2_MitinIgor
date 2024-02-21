using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    public class RailwayTransport(double distance, double weight) : Transport(distance)      
    {
        double Weight = weight;//В кг

        public override double Costs()
        {
            Cost = Weight * Distance;
            
            return Cost;
        }
        public override double Prices()
        {
            Price = Cost * 1.15;
            
            return Price;
        }
        public override string Info()
        {
           Costs();
           Prices();
           return $"Себестоимость железнодорожной перевозки: {Cost}\nЦена железнодорожной перевозки: {Price}";
        }
    }
}
