using System;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("I am broken");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("I am broken");
            return this;
        }

        public ILightState Fix()
        {
            Console.WriteLine("You fix it! Turning off the light");
            return new IAmOff();
        }
    }
}
