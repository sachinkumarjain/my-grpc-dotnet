﻿using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CreditRatingService.Protos;
using Grpc.Net.Client;

namespace CreditRatingClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            var serverAddress = "https://localhost:5001";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // The following statement allows you to call insecure services. To be used only in development environments.
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                serverAddress = "http://localhost:5000";
            }

            var channel = GrpcChannel.ForAddress(serverAddress);
            var client = new CreditRatingCheck.CreditRatingCheckClient(channel);
            var creditRequest = new CreditRequest { CustomerId = "id0201", Credit = 7000 };
            var reply = await client.CheckCreditRequestAsync(creditRequest);

            Console.WriteLine($"Credit for customer {creditRequest.CustomerId} {(reply.IsAccepted ? "approved" : "rejected")}!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
