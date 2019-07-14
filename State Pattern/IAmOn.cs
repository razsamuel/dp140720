using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOn : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Turning off the light....");
            return new IAmOff();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("You broke the light");
            return new IAmBroken();
        }

        public ILightState Fix()
        {
            Console.WriteLine("The light not broken..");
            return this;
        }
    }
}
