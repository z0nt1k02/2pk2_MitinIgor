using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    public class SeaTransport: Transport
    {
        double PortDues;
        
        public SeaTransport(double distance,double portDues) : base (distance) 
        {
            
            PortDues = portDues;
            
        }
        
        public override double Costs()
        {
            Cost = Distance * 1000 + PortDues;
            return Cost;
        }
        public override double Prices()
        {
            Price = Cost + Cost * 0.25;
            return Price;
        }
        public override string Info()
        {
            Costs();
            Prices();
            return $"Себестоимость воздушной перевозки:{Cost + 1}\nЦена воздушной перевозки{Price + 1}";
        }
    }
}
