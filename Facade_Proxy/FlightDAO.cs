using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy
{
    class FlightDAO
    {
        public void insertTicket()
        {
            Console.WriteLine("buy new ticket");
        }
        public void getTickets()
        {
            Console.WriteLine("this is all your tickets");
        }
        public void insertFlight()
        {
            Console.WriteLine("create new flight");
        }
        public void removeFlight()
        {
            Console.WriteLine("remove the flight");
        }
        public void insertCustomer()
        {
            Console.WriteLine("add new customer");
        }
        public void insertCompany()
        {
            Console.WriteLine("add new company");
        }
    }
}
