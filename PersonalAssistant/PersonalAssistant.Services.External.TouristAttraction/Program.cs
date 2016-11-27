namespace PersonalAssistant.Services.External.Tourist
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
                                   Name = "Activity 1",
                                   Description = "Chris Brown Concert",
                                   Location = "Destination",
                                   Price = 20,
                                   EventDate = new DateTime(2016, 12, 24),
                                   ActivityType = "Concert"
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