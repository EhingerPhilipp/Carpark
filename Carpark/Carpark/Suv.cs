using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{
    public class Suv : Consumer
    {
        public Suv (int typeId, string make, string model, string typeName, string color, int ccm, double fuelConsumption, int maxSpeed)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            Ccm = ccm;
            TyreAmount = 4;
            Seats = 7;
            FuelConsumption = fuelConsumption;
            Speed = 0;
            MaxSpeed = maxSpeed;
        }

        public override void Drive()
        {
            Console.WriteLine($"{this.GetType().Name} is driving ... wrrrrr");
        }
    }
}
