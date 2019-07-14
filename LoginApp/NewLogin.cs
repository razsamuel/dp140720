using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class NewLogin : LoginBase
    {
        public NewLogin(Context ctx) : base(ctx)
        {
        }

        public override void login(string password)
        {
            if (password == Program.ROOT_PASSWORD)
            {
                Console.WriteLine("Connected");
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                Console.WriteLine("Wrong password...");
                  ctx.State = new LoginFailed(ctx);
            }
        }

        public override void restart()
        {
            Console.WriteLine("do nothing");
        }
    }
}
