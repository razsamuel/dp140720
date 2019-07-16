using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {

        private Context ctx = new Context();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello....");

            ctx.Save(rText);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            ctx.LoadPrev(rText);
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            ctx.LoadNext(rText);
        }
    }
}
