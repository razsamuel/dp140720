using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{

    public enum LOG_LEVEL{
        FATAL,
        ERROR,
        INFO,
        DEBUG

    }
    public abstract class LogHandlerBase
    {

        protected LogHandlerBase next;

        public abstract void log(string message , LOG_LEVEL log_level);

        public void SetNext(LogHandlerBase next)
        {
            this.next = next;
        }

    }
}
