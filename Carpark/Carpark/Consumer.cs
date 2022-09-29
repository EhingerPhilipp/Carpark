using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{
    public abstract class Consumer : Vehicle
    {
        public int Seats { get; set; }
        public double FuelConsumption { get; set; }
    }
}
