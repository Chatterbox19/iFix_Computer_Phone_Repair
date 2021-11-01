using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFix_Computer_Phone_Repair
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> lstCustomer = new List<Customer>();
            lstCustomer.Add(new Customer());
            lstCustomer[0].Name = "Andrew";
            lstCustomer[0].Device = "Pixel";
            lstCustomer[0].Phone = 8148538955;

            foreach (Customer oCust in lstCustomer)
            {
                Console.WriteLine(oCust.getData());
                Console.WriteLine(oCust.getDataOne());
            }
            Console.WriteLine();

        }
    }
}