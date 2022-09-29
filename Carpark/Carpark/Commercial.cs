using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark
{
    public abstract class Commercial : Vehicle
    {
        public double LoadCapacity { get; set; }
        public double ToeCapacity { get; set; }
        public bool SpecialPermit { get; set; }

        public abstract void Load();
        public abstract void Unload();
    }
}
