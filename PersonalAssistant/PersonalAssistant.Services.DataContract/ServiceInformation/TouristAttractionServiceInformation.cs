namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using System;

    using PersonalAssistant.Services.DataContract.Base;

    public class TouristAttractionServiceInformation : ServiceInformation
    {
        public DateTime EventDate { get; set; }

        public string ActivityType { get; set; }
    }
}