using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandle25 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 25)
            {
                Console.WriteLine($"Giving 25 x {amount / 25} bills");
            }

            if (amount % 25 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 25);
                }
            }
        }
    }
}
