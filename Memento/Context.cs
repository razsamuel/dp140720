using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void LoadPrev(RichTextBox richText)
        {
            if (careTake.GetLast(false) != null && careTake.GetLast(false).savedText != null)
                richText.Text = careTake.GetLast(true).savedText;
        }
        public void LoadNext(RichTextBox richText)
        {
            if (careTake.getNext(false) != null && careTake.getNext(false).savedText != null)
                richText.Text = careTake.getNext(true).savedText;
        }
    }
}
