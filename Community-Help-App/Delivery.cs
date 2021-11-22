using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Help_App
{
    class Delivery
    {
        public string DeliveryDate { get; set; }
        public string CustID { get; set; }
        public string VolunteerID { get; set; }
        public string AmountDue { get; set; }

        public override string ToString()
        {
            return DeliveryDate + ", " + CustID + ", " + VolunteerID + ", " + AmountDue;
        }
    }
}
