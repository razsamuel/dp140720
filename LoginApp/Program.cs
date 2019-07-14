using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class Program
    {
        public static string ROOT_PASSWORD = "12345";
        static void Main(string[] args)
        {


            Context ctx = new Context();
            NewLogin newLogin = new NewLogin(ctx);
            ctx.Init(newLogin);
            ctx.login("1234");
            ctx.login("123");
            ctx.login("1");
            ctx.restart();
            ctx.login("12345");
            ctx.restart();
            ctx.login("12345");
        }
    }
}
