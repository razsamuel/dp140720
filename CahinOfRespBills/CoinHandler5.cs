using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class CoinHandler5 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 5)
            {
                Console.WriteLine($"Giving 5 x {amount / 5} coins");
            }

            if (amount % 5 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 5);
                }
            }
        }
    }
}
