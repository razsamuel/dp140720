using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : Device
    {
        public TV(float max) : base(max)
        {
        }

        public override void pressNext()
        {
            this.state = (this.state + 1) % this.max;
        }

        public override void pressPrevious()
        {
            if (state > 1)
            {
                this.state = this.state - 1;
            }
        }

        public override void printStatus()
        {
            string message = "turn on";
            if (!isOn)
                message = "turn off"; 
            Console.WriteLine("I am on channel : {0} and im {1}", this.state , message);
        }
    }
}
