namespace PersonalAssistant.Services.DataContract.ServiceInformation
{
    using PersonalAssistant.Services.DataContract.Base;

    public class TransportServiceInformation : ServiceInformation
    {
        public string YourLocation { get; set; }

        public string TransportType { get; set; }

        public string TransportFromCountry { get; set; }

        public string TransportFromCity { get; set; }
    }
}