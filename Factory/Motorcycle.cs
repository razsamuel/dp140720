using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Motorcycle : Vehicle
    {

        protected string handBreakVendor;

        public Motorcycle(string model, float cylinder, string color, int numberOfWheels, string handBreakVendor) : base(model, cylinder, color, numberOfWheels)
        {
            this.handBreakVendor = handBreakVendor;
        }

        public override string ToString()
        {
            return "Motorcycle : " + base.ToString() + $" { handBreakVendor}";
        }
    }
}
