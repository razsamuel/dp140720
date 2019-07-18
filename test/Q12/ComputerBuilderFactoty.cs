using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ComputerBuilderFactory
    {
        public static ComputerBuilder createComputer(string computerType)
        {
            if(computerType == "Gaming")
            {
                return new GamingComputerBuilder();
            }
            if(computerType == "Office")
            {
                return new OfficeComputerBuilder();
            }
            return null;
        }
    }
}
