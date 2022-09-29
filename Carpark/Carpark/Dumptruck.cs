using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{
    public class Dumptruck : Commercial
    {
        public Dumptruck(int typeId, string make, string model, string typeName, string color, int ccm, int tyreAmount, double loadCapacity, double toeCapacity, int maxSpeed)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            Ccm = ccm;
            TyreAmount = tyreAmount;
            LoadCapacity = loadCapacity;
            ToeCapacity = toeCapacity;
            Speed = 0;
            MaxSpeed = maxSpeed;
        }

        public override void Drive()
        {
            Console.WriteLine($"{this.GetType().Name} is driving .... tuck tuck tuck"); ;
        }

        public override void Load()
        {
            Console.WriteLine($"{this.GetType().Name} is loaded with an excavator.");
        }

        public override void Unload()
        {
            Console.WriteLine($"{this.GetType().Name} tilts its truck bed to unload.");
        }
    }
}
