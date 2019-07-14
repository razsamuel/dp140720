using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class LoginSucceed : LoginBase
    {
        public LoginSucceed(Context ctx) : base(ctx)
        {
        }

        public override void login(string password)
        {
            Console.WriteLine("you are already connected");
        }
        public override void restart()
        {
            Console.WriteLine("disconnected..back to new login");
            ctx.State = new NewLogin(ctx);
        }
    }
}
