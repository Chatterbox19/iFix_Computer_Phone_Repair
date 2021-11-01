using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFix_Computer_Phone_Repair
{
    class Customer
    {
        public string Name;
        public string Device;
        public double Phone;

        public string getData()
        {
            return Device;


        }

        public double getDataOne()
        {
            return Phone;
        }
    }
}