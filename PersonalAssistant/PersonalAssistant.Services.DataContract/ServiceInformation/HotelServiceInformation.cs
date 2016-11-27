namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using System;

    using PersonalAssistant.Services.DataContract.Base;

    public class HotelServiceInformation : ServiceInformation
    {
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int NumberOfStars { get; set; }

        public int NumberOfPeoplePerRoom { get; set; }

        public int NumberOfRooms { get; set; }
    }
}