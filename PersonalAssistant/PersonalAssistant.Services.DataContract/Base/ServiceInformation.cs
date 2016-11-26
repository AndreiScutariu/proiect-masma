using System;

namespace PersonalAssistant.Services.DataContract.Base
{
    public abstract class ServiceInformation
    {
        protected ServiceInformation()
        {
            Type = GetType();
            RegisterAt = DateTime.Now;;
        }

        public Type Type { get; set; }

        public ServiceType ServiceType { get; set; }

        [Label(Value = "Enter the name of the service: ")]
        public string Name { get; set; }

        [Label(Value = "Enter a simple description of the service: ")]
        public string Description { get; set; }

        [Label(Value = "Enter the location of the service: ")]
        public string Location { get; set; }

        [Label(Value = "Enter the price of the service: ")]
        public int Price { get; set; }

        public DateTime RegisterAt { get; set; }
    }
}