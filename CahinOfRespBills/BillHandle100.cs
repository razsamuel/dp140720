using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandle100 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 100)
            {
                Console.WriteLine($"Giving 100 x {amount / 100} bills");
            }

            if (amount % 100 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 100);
                }
            }
        }
    }
}
