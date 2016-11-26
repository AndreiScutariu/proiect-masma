using System;
using System.IO;
using Newtonsoft.Json;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.Transport
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var information = new TransportServiceInformation
            {
                Name = "Transport 1",
                Description = "Some transport service",
                Location = "Destination",
                Price = 400,
                YourLocation = "Home Location"
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