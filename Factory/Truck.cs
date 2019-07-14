using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : Vehicle
    {
        protected string radioStations;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string radioStations) : base(model, cylinder, color, numberOfWheels)
        {
            this.radioStations = radioStations;
        }

        public override string ToString()
        {
            return "Truck " + base.ToString() + $" {radioStations}";
        }
    }
}
