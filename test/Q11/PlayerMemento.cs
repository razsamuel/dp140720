using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class PlayerMemento
    {
        public int value;
        public int XIndex;
        public int YIndex;

        public PlayerMemento(int value , int XIndex ,int YIndex)
        {
            this.XIndex = XIndex;
            this.YIndex = YIndex;
            this.value = value;
        }

    }
}
