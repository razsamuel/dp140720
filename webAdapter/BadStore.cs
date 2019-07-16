using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BadStore : IDBwebData
    {
        
        public void store(WebClientData webClientData)
        {
            Console.WriteLine("web client data={0}",webClientData.ID);
        }
    }
}
