
using Grpc.Core;
using GrpcService.Impl;
using Snai.GrpcService.Protocol;
using System;

namespace ConsoleServer
{
    class Program
    {
        private static Server _server;

        static void Main(string[] args)
        {
            _server = new Server
            {
                Services = { MsgService.BindService(new MsgServiceImpl()) },
                Ports = { new ServerPort("localhost", 9008, ServerCredentials.Insecure) }
            };
            _server.Start();

            Console.WriteLine("grpc ServerListening On Port 9008");
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            _server?.ShutdownAsync().Wait();

        }
          
    }
    }

