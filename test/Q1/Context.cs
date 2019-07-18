using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        IGameState state;

        public Context(IGameState state)
        {
            this.state = state;
        }

        public void levelUp()
        {
            this.state = state.levelUp();
        }

        public void getDamage()
        {
            this.state = state.reciveDamage();
        }
    }
}
