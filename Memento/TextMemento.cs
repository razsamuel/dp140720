using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextMemento
    {
        public readonly string savedText;

        public TextMemento(string savedText)
        {
            this.savedText = savedText;
        }

    }
}
