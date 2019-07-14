using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class LoginFailed : LoginBase
    {
        int numFailures = 0;
        int maxFailures = 2;
        public LoginFailed(Context ctx) : base(ctx)
        {
        }

        public override void login(string password)
        {
            if(password == Program.ROOT_PASSWORD)
            {
                Console.WriteLine("login successfully");
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                numFailures++;
                if(numFailures == maxFailures)
                {
                    Console.WriteLine("too much tries! you locked!");
                    ctx.State = new Locked(ctx);
                }
                else
                {
                    Console.WriteLine("you have {0} more tries",maxFailures - numFailures);
                }
            }
        }
        public override void restart()
        {
            ctx.State = new NewLogin(ctx);
        }
    }
}
