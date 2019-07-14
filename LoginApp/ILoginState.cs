using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public interface ILoginState
    {
        void login(string password);

        void restart();
    }
}
