using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class CustomerProxy : ClientProxy
    {
        void buyTicket()
        {
            FlightSystemFacade flightSystemFacade = new FlightSystemFacade();
            flightSystemFacade.buyTicket();
        }
        void getTickets()
        {
            FlightSystemFacade flightSystemFacade = new FlightSystemFacade();
            flightSystemFacade.showMyTickets();
        }
    }
}
