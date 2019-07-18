using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Proxy
    {
        public void getFuelState()
        {
            DriveDAO driveDAO = new DriveDAO();
            driveDAO.getFuelState();
        }
        public void getLocation()
        {
            DriveDAO driveDAO = new DriveDAO();
            driveDAO.getLocation();
        }
    }
}
