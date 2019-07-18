using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class BackTrain : GymTemplateBase
    {

        protected override void Train()
        {
            Console.WriteLine("doing a pull up day");
        }
    }
}
