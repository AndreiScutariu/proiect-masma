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
                                                City = "Iasi",
                                                Country = "Romania",
                                                DateStart = new DateTime(2016,12,1),
                                                DateEnd =  new DateTime(2016, 12, 31),
                                                Description = "Very nice environment",
                                                Name = "Hotel Unirea",
                                                NumberOfPeoplePerRoom = 2,
                                                NumberOfRooms = 10,
                                                NumberOfStars = 4,
                                                Price = 120                                                
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