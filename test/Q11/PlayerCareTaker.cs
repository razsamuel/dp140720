using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class PlayerCareTaker
    {
        List<PlayerMemento> allMementos = new List<PlayerMemento>();
        int index = 0;
        public void AddMemento(PlayerMemento memento)
        {
            if (allMementos.Count - 1 > index)
            {
                allMementos.RemoveRange(index, allMementos.Count - index);
            }

            allMementos.Add(memento);
            index = allMementos.Count;
        }

        public PlayerMemento GetLast(bool changeIndex)
        {
            if (index > 0)
            {
                PlayerMemento playerMemento = allMementos[index - 1];
                if (changeIndex)
                {
                    index -= 1;
                }
                return playerMemento;

            }
            return null;
        }

        public PlayerMemento getNext(bool changeIndex)
        {
            if (index < allMementos.Count - 1)
            {
                PlayerMemento playerMemento = allMementos[index + 1];
                if (changeIndex)
                {
                    index += 1;
                }
                return playerMemento;

            }
            return null;
        }
    }
}