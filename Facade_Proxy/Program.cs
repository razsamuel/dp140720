using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            AdminProxy adminProxy = (AdminProxy)(connectionFactory.getProxy("admin", "admin"));
            adminProxy.createCompany();
            adminProxy.CreateCustomer();
        }
    }
}
