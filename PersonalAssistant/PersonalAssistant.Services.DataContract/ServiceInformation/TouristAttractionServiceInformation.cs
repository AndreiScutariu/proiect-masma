namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using System;

    using PersonalAssistant.Services.DataContract.Base;

    public class TouristAttractionServiceInformation : ServiceInformation
    {
        public string ActivityType { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
    }
}