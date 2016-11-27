namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using PersonalAssistant.Services.DataContract.Base;

    public class HotelServiceInformation : ServiceInformation
    {
        public int NumberOfStars { get; set; }

        public int NumberOfPeoplePerRoom { get; set; }
    }
}