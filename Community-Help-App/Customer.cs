using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Help_App
{
    class Customer
    {
        public string CustID { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustTel { get; set; }
        public string CustInternetAccess { get; set; }

        public override string ToString()
        {
            return CustID + ", " + CustName + ", " + CustAddress + ", " + CustTel + ", " + CustInternetAccess;
        }
    }
}
