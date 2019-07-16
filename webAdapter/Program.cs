using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdapter;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBwebData webData = new IDBAdapter();
            WebClientData data = new WebClientData("bad", "1", "ip", true);
            storeClient(webData, data);
        }
        static void storeClient(IDBwebData webData, WebClientData data)
        {
            webData.store(data);
        }
    }
}
