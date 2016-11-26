namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using PersonalAssistant.Services.DataContract.Base;

    public class HotelServiceInformation : Base.ServiceInformation
    {
        [Label(Value = "Enter the number of stars of the hotel service: ")]
        public int NumberOfStars { get; set; }
    }
}