using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{
    internal class Hypercar : Consumer, ISportsvehicle
    {
        public Hypercar (int typeId, string make, string model, string typeName, string color, int ccm, double fuelConsumption, int maxSpeed)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            Ccm = ccm;
            TyreAmount = 4;
            Seats = 2;
            FuelConsumption = fuelConsumption;
            Speed = 0;
            MaxSpeed = maxSpeed;
        }

        public override void Drive()
        {
            Console.WriteLine($"{this.GetType().Name} is driving ... wruuuuuuuuummmm");
        }

        public void Showoff()
        {
            Console.WriteLine($"{this.GetType().Name} is reving his engine ... Wrauuu pa pa pa pa wrrauuuu pa pa pa");
        }
    }
}
