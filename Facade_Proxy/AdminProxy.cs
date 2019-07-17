using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class AdminProxy : ClientProxy
    {
        public void CreateCustomer()
        {
            FlightSystemFacade flightSystemFacade = new FlightSystemFacade();
            flightSystemFacade.createCustomer();
        }
        public void createCompany()
        {
            FlightSystemFacade flightSystemFacade = new FlightSystemFacade();
            flightSystemFacade.CreateCompany();
        }
    }
}
