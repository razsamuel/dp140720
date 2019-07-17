using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Device
    {
        public bool isOn;
        public float state;
        public float max;

        public Device(float max)
        {
            this.isOn = false;
            this.state = 1;
            this.max = max;
        }

        public abstract void printStatus();

        public abstract void pressNext();

        public abstract void pressPrevious();

        public void turnOn()
        {
            this.isOn = true;
        }
        public void turnOff()
        {
            this.isOn = false;
        }

        
          
    }
}
