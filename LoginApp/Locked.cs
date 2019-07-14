using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class Locked : LoginBase
    {
        public Locked(Context ctx) : base(ctx)
        {
        }

        public override void login(string password)
        {
            Console.WriteLine("you are locked , you cant login!");
        }
        public override void restart()
        {
            Console.WriteLine("Back to new login state");
            ctx.State = new NewLogin(ctx);
        }
    }
}
