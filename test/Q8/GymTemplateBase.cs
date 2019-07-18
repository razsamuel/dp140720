using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public abstract class GymTemplateBase : TemplateTrain
    {
        protected override void ChangeCloths() {
            Console.WriteLine("changing to my fit clothes");
        }
        protected override void DrinkWater() {
            Console.WriteLine("drinking water");
        }
        protected override void Train() {
            Console.WriteLine("doing a gym train");
        }
        protected override void Shower() {
            Console.WriteLine("im showering");
        }
    }
}
