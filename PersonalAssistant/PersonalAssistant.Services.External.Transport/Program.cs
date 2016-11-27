namespace PersonalAssistant.Services.External.Transport
{
    using System;
    using System.IO;

    using Newtonsoft.Json;

    using PersonalAssistant.Services.Common;
    using PersonalAssistant.Services.DataContract;
    using PersonalAssistant.Services.DataContract.ServiceInformation;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var information = new TransportServiceInformation
                                  {
                                      City = "Iasi",
                                      Country = "Romania",
                                      Description = "Cheapest way anywhere you go",
                                      Name = "Name",
                                      Price = 50,
                                      RegisterAt = DateTime.Now,
                                      ServiceType = ServiceType.Transport,
                                      TransportFromCity = "Piatra Neamt",
                                      TransportFromCountry = "Romania",
                                      TransportType = "Rail transportation"
                                  };

            var service = RegisterService(information);

            Console.WriteLine("Register new service");
            Console.WriteLine(JsonConvert.SerializeObject(service));
        }

        private static Service RegisterService(TransportServiceInformation information)
        {
            var service = new Service
                              {
                                  ServiceType = ServiceType.Transport,
                                  ServiceInformation = JsonConvert.SerializeObject(information)
                              };

            File.WriteAllText($"{Resources.DropFolderPaht}{Guid.NewGuid()}.json", JsonConvert.SerializeObject(service));

            return service;
        }
    }
}