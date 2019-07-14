using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Car : Vehicle
    {
        protected string drivingWheelHeater;

        public Car(string model, float cylinder, string color, int numberOfWheels, string drivingWheelHeater) : base(model, cylinder, color, numberOfWheels)
        {
            this.drivingWheelHeater = drivingWheelHeater;
        }

        public override string ToString()
        {
            return "Car " + base.ToString() + $" {drivingWheelHeater}";
        }
    }
}
