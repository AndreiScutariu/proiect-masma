namespace PersonalAssistant.Services.External.TouristAttraction
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
            var activity = new TouristAttractionServiceInformation
                               {
                                    ActivityType = "Concert",
                                    DateStart = new DateTime(2016,12,15),
                                    DateEnd = new DateTime(2016,12,15),
                                    Name = "Rihanna Christmass Party",
                                    Description = "Christmass Party",
                                    Price = 70,
                                    Country = "Romania",
                                    City = "Iasi",
                                    RegisterAt = DateTime.Now,
                                    ServiceType = ServiceType.TouristAttraction
                               };

            var service = RegisterService(activity);

            Console.WriteLine("Register new service");
            Console.WriteLine(JsonConvert.SerializeObject(service));
        }

        private static Service RegisterService(TouristAttractionServiceInformation activity)
        {
            var service = new Service
                              {
                                  ServiceType = ServiceType.TouristAttraction,
                                  ServiceInformation = JsonConvert.SerializeObject(activity)
                              };

            File.WriteAllText($"{Resources.DropFolderPaht}{Guid.NewGuid()}.json", JsonConvert.SerializeObject(service));

            return service;
        }
    }
}