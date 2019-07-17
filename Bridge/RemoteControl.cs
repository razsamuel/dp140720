using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        Device device;

        public RemoteControl(Device device)
        {
            this.device = device;
        }
        public RemoteControl()
        {

        }
        public Device getDevice()
        {
            return device;
        }
        public void setDevice(Device device)
        {
            this.device = device;
        }
        public void on()
        {
            this.device.turnOn();
        }
        public void off()
        {
            this.device.turnOff();
        }
        public void next()
        {
            this.device.pressNext();
        }
        public void prev()
        {
            this.device.pressPrevious();
        }

    }
}
