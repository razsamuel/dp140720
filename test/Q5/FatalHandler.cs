using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class FatalHandler : LogHandlerBase
    {
        public override void log(string message, LOG_LEVEL log_level)
        {
            if(log_level == LOG_LEVEL.FATAL)
            {
                Console.WriteLine("Fatal: {0}",message);
                Console.WriteLine("Write to file");
                Console.WriteLine("Sending SMS");


            }
            if (next != null)
            {
                next.log(message, log_level);
            }
        }
    }
}
