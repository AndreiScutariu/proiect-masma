namespace PersonalAssistant.Services.DataContract.Base
{
    using System;

    public abstract class ServiceInformation
    {
        protected ServiceInformation()
        {
            Type = GetType();
            RegisterAt = DateTime.Now;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int Price { get; set; }

        #region infrastructure

        public Type Type { get; set; }

        public ServiceType ServiceType { get; set; }

        public DateTime RegisterAt { get; set; }

        #endregion
    }
}