using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{

    public abstract class Vehicle
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }
        public int Ccm { get; set; }
        public int TyreAmount { get; set; }
        public bool EngineRunning { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }

        public void StartEngine()
        {
            if(EngineRunning)
            {
                Console.WriteLine("Engine is already running.");
            } else
            {
                Console.WriteLine("Starting the engine");
                EngineRunning = true;
            }
        }
        public abstract void Drive();
        public void Accelerate()
        {
            if (Speed < MaxSpeed)
            {
                Console.WriteLine($"{this.GetType().Name} is accelerating");
                Speed++;
            } else
            {
                Console.WriteLine($"{this.GetType().Name} has reached its speedlimit");
            }
        }
        public void Declerate()
        {
            if (Speed > 0)
            {
                Console.WriteLine($"{this.GetType().Name} is decelerating");
                Speed--;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} is already standing still.");
            }
        }
    }
}
