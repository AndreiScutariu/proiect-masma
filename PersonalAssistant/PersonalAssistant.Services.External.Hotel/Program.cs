using System;
using System.IO;
using Newtonsoft.Json;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.Hotel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //get information about new service
            var hotelServiceInformation = new HotelServiceInformation
            {
                Description = "Some hotel service",
                Location = "Location 1",
                NumberOfStars = 3,
                Price = 100
            };

            //register the new service
            var service = RegisterService(hotelServiceInformation);

            Console.WriteLine("Register new service");
            Console.WriteLine(JsonConvert.SerializeObject(service));
        }

        private static Service RegisterService(HotelServiceInformation hotelServiceInformation)
        {
            var service = new Service
            {
                ServiceType = ServiceType.Hotel,
                ServiceInformation = JsonConvert.SerializeObject(hotelServiceInformation)
            };

            File.WriteAllText($"{Resources.DropFolderPaht}{Guid.NewGuid()}.json", JsonConvert.SerializeObject(service));

            return service;
        }
    }
}