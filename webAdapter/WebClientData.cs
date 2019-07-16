using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientData 
    {

        public string name;
        public string ID;
        public string IP;
        public Boolean ssl;

        public WebClientData(string name , string ID , string IP , Boolean ssl)
        {
            this.name = name;
            this.ID = ID;
            this.IP = IP;
            this.ssl = ssl;
        }
    }
}
