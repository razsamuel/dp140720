using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler200 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 200)
            {
                Console.WriteLine($"Giving 200 x {amount / 200} bills");
            }

            if (amount % 200 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 200);
                }
            }
        }
    }
}
