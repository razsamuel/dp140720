using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class HamburgerBuilder
    {
        protected Hamburger hamburger;

        public Hamburger GetHamburger()
        {
            if (hamburger == null)
                throw new HamburgerNotReadyException("First prepare the hamburger!");

            return hamburger;
        }

        public void BuildHamburger()
        {
            this.hamburger = new Hamburger();
            PrepareBun();
            PrepareVegg();
            PrepareMain();
            PrepareTopping();
            PreparePriceLabel();
        }

        protected abstract void PrepareBun();

        protected abstract void PrepareVegg();

        protected abstract void PrepareMain();

        protected abstract void PrepareTopping();

        protected abstract void PreparePriceLabel();
    }
}
