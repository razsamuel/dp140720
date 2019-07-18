using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class LegTrain : GymTemplateBase
    {

        protected override void Train()
        {
            Console.WriteLine("doing a Squat day");
        }
    }
}
