namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using PersonalAssistant.Services.DataContract.Base;

    public class TransportServiceInformation : Base.ServiceInformation
    {
        [Label(Value = "Enter the start point of the location service: ")]
        public string YourLocation { get; set; }
    }
}