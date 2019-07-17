using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class ConnectionFactory
    {
        public ClientProxy getProxy(string username , string password)
        {
            if(username.Equals("raz") && password.Equals("1234"))
            {
                return new CustomerProxy();
            }
            else if (username.Equals("admin") && password.Equals("admin"))
            {
                return new AdminProxy();
            }
            else if (username.Equals("elal") && password.Equals("elal"))
            {
                return new CompanyProxy();
            }
            return null;
        }

    }
}
