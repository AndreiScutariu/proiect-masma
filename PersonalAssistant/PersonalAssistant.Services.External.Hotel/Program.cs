namespace PersonalAssistant.Services.External.Hotel
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
            Console.WriteLine("Enter the name of hotel: ");

            var hotelServiceInformation = new HotelServiceInformation
                                              {
                                                  Name = "Hotel 1",
                                                  Description = "Some hotel service",
                                                  Location = "Location 1",
                                                  NumberOfStars = 3,
                                                  Price = 100
                                              };

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