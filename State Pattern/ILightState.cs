using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface ILightState
    {
        ILightState TurnOn();

        ILightState TurnOff();

        ILightState Fix();
    }
}
