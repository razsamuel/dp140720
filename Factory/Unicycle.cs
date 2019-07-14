using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Unicycle : Vehicle
    {
        protected string stability;

        public Unicycle(string model, float cylinder, string color, int numberOfWheels, string stability) : base(model, cylinder, color, numberOfWheels)
        {
            this.stability = stability;
        }

        public override string ToString()
        {
            return "Unicycle " + base.ToString() + $" {stability}";
        }
    }
}
