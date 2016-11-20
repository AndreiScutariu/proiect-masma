﻿using System;
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
            //get information about new service
            var information = new TransportServiceInformation
            {
                Description = "Some hotel service",
                Location = "Destination",
                Price = 100,
                YourLocation = "Home Location"
            };

            //register the new service
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