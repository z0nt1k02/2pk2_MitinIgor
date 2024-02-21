using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    public class AirTransport:Transport       
    {
        double Weight;//В кг
        public AirTransport(double distance,double weight):base(distance) 
        {            
           Weight = weight;
        }
        public override double Costs()
        {
            Cost = Weight * 300 + Distance * 1000;
            return Cost;
        }
        public override double Prices()
        {
            Price = Cost * 1.3;
            return Price;
        }
        public override string Info()
        {
            Costs();
            Prices();
            return $"Себестоимость воздушной перевозки: {Cost}\nЦена воздушной перевозки {Price}";
        }
    }
}
