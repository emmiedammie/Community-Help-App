using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Help_App
{
    class Volunteer
    {
        public string VolunteerId { get; set; }
        public string VolunteerName { get; set; }
        public string VolunteerAddress { get; set; }
        public string VolunteerAvailability { get; set; }
        public string VolunteerPVGStatus { get; set; }
        public string VolunteerVehicleLicense { get; set; }

        public override string ToString()
        {
            return VolunteerId + ", " + VolunteerName + ", " + VolunteerAddress + ", " + VolunteerAvailability + ", " + VolunteerPVGStatus + ", " + VolunteerVehicleLicense;
        }
    }
}
