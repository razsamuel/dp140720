using Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAdapter
{
    class IDBAdapter : IDBwebData
    {



        public void store(WebClientData webClientData)
        {
            ClientData clientData = new ClientData(webClientData.name, webClientData.ID);
            Console.WriteLine(clientData.ID + "," + clientData.name);
        }
    }
}
