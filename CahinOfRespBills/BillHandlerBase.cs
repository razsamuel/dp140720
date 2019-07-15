using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public abstract class BillHandlerBase
    {

        protected BillHandlerBase next;

        public abstract void Handle(int amount);

        public void SetNext(BillHandlerBase next)
        {
            this.next = next;
        }

    }
}
