using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        ILightState state;

        public Context(ILightState state)
        {
            this.state = state;
        }

        public void pressedOn()
        {
            this.state = state.TurnOn();
        }

        public void pressedOff()
        {
            this.state = state.TurnOff();
        }

        public void fix()
        {
            this.state = state.Fix();
        }
    }
}
