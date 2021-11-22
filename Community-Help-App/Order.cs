using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Help_App
{
    class Order
    {
        public string GroceriesItems { get; set; }
        public string StoreName { get; set; }
        public string MedicalList { get; set; }
        public string DeliveryDate { get; set; }
        public string TotalOrderAmount { get; set; }

        public override string ToString()
        {
            return GroceriesItems + ", " + StoreName + ", " + MedicalList + ", " + DeliveryDate + ", " + TotalOrderAmount; 

        }
        
    }
}