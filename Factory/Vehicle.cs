using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Vehicle
    {
        protected string model;

        protected float cylinder;

        protected string color;

        protected int numberOfWheels;

        public Vehicle(string model, float cylinder, string color, int numberOfWheels)
        {
            this.model = model;
            this.cylinder = cylinder;
            this.color = color;
            this.numberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return $"{model} {cylinder} {color} {numberOfWheels}";
        }
    }
}
