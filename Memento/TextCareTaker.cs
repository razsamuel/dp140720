using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> allMementos = new List<TextMemento>();
        int index = 0;
        public void AddMemento(TextMemento memento)
        {
            if (allMementos.Count - 1 > index)
            {
                allMementos.RemoveRange(index, allMementos.Count - index);
            }

            allMementos.Add(memento);
            index = allMementos.Count;
        }

        public void RemoveMemento()
        {
        }

        public TextMemento GetLast(bool changeIndex)
        {
            if (index > 0)
            {
                TextMemento textMemento = allMementos[index - 1];
                if (changeIndex)
                {
                    index -= 1;
                }
                return textMemento;

            }
            return new TextMemento("");
        }

        public TextMemento getNext(bool changeIndex)
        {
            if (index < allMementos.Count - 1)
            {
                TextMemento textMemento = allMementos[index + 1];
                if (changeIndex)
                {
                    index += 1;
                }
                return textMemento;

            }
            return null;
        }
    }
}