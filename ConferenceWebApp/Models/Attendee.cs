using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferenceWebApp.Models
{
    public class Attendee //This is the class which represents and stores the information of each Attendee 
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String jobTitle { get; set; }
        public String company { get; set; }
        public String dateOfBirth { get; set; }
        public bool attended { get; set; }

    }

}