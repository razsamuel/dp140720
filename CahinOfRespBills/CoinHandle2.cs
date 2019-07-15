using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class CoinHandle2 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 2)
            {
                Console.WriteLine($"Giving 2 x {amount / 2} coins");
            }

            if (amount % 2 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 2);
                }
            }
        }
    }
}
