using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{
    public class Lorry : Commercial
    {
        public Lorry(int typeId, string make, string model, string typeName, string color, int ccm, int tyreAmount, double loadCapacity, double toeCapacity, int maxSpeed)
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
            Console.WriteLine($"{this.GetType().Name} is driving ... brumbumbumbum");
        }

        public override void Load()
        {
            Console.WriteLine($"Containers are loaded in {this.GetType().Name} with forklifts");
        }

        public override void Unload()
        {
            Console.WriteLine($"Containers are unloaded from {this.GetType().Name} with forklifts");
        }
    }
}
