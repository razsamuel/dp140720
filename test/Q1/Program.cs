using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new IAmFix(50,1));
            ctx.levelUp();
            ctx.levelUp();
            for (int i = 0; i < 45; i++)
            {
                ctx.getDamage();
            }
            ctx.levelUp();
            ctx.levelUp();

        }
    }
}
