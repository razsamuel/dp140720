using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public abstract class TemplateTrain
    {
        protected abstract void ChangeCloths();
        protected abstract void DrinkWater();
        protected abstract void Train();
        protected abstract void Shower();
            
        public void Run()
        {
            ChangeCloths();
            DrinkWater();
            Train();
            Shower();
        }
    }
}
