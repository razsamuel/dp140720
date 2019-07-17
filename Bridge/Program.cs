using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl(new TV(20));
            for (int i = 0; i < 30; i++)
            {
                remoteControl.prev();
            }
            remoteControl.off();
            remoteControl.getDevice().printStatus();
        }
    }
}
