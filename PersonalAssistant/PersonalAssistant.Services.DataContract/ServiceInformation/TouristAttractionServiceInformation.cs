using System;
using System.Collections.Generic;

namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    public class TouristAttractionServiceInformation : Base.ServiceInformation
    {
        public DateTime EventDate { get; set; }

        public string ActivityType { get; set; }
    }
}