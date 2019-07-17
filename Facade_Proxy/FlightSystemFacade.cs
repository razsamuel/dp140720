using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class FlightSystemFacade : ICustomer, ICompany, IAdmin
    {
        FlightDAO flightDAO;

        public FlightSystemFacade()
        {
            flightDAO = new FlightDAO();
        }
        public void buyTicket()
        {
            flightDAO.insertTicket();
        }

        public void cancelFlight()
        {
            flightDAO.removeFlight();
        }

        public void CreateCompany()
        {
            flightDAO.insertCompany();
        }

        public void createCustomer()
        {
            flightDAO.insertCustomer();
        }

        public void createFlight()
        {
            flightDAO.insertFlight();
        }

        public void showMyTickets()
        {
            flightDAO.getTickets();
        }
    }
}
