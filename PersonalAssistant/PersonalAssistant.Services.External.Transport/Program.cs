﻿namespace PersonalAssistant.Services.External.Transport
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
                                      Description = "Description",
                                      Name = "Name",
                                      Price = 200,
                                      RegisterAt = DateTime.Now,
                                      ServiceType = ServiceType.Transport,
                                      TransportFromCity = "Falticeni",
                                      TransportFromCountry = "Romania",
                                      TransportType = "Plane"
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