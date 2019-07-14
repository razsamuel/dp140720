using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public abstract class LoginBase : ILoginState
    {

        protected Context ctx;

        protected LoginBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void login(string password);

        public abstract void restart();


    }
}
