using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class CompanyProxy : ClientProxy
    {
        void createFlight()
        {
            FlightSystemFacade flightSystemFacade = new FlightSystemFacade();
            flightSystemFacade.createFlight();
        }
        void cancelFlight()
        {
            FlightSystemFacade flightSystemFacade = new FlightSystemFacade();
            flightSystemFacade.cancelFlight();
        }
    }
}
