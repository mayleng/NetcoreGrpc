using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grpc.Core;
using Snai.GrpcService.Protocol;
using GrpcService.Impl;

namespace GRPCServer.Pages
{
    public class IndexModel : PageModel
    {
        private static Server _server;

        public string  ServerMes { get; private set; } = " ";

        public void OnGet()
        {
            _server = new Server
            {
                Services = { MsgService.BindService(new MsgServiceImpl()) },
                Ports = { new ServerPort("localhost", 9008, ServerCredentials.Insecure) }
            };
            _server.Start();
            
            ServerMes="grpc ServerListening On Port 9008";
           
           // _server?.ShutdownAsync().Wait();

        }
    }
}
