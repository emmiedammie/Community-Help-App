using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Help_App
{
    class Administrator
    {
        public string AdminID { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
      

        public override string ToString()
        {
            return AdminID + "Welcome ";
        }
    }
}
