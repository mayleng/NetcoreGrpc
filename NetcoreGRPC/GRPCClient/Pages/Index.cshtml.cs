using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grpc.Core;
using Snai.GrpcService.Protocol;

namespace GRPCClient.Pages
{
    public class IndexModel : PageModel
    {
        public string ClientMes { get; private set; } = " ";
        public void OnGet()
        {
            GetMsgSumReply msgSum = MsgServiceClient.GetSum(10, 6);

            ClientMes = "grpc Client Call GetSum():" + msgSum.Sum;
        }


    }
}
