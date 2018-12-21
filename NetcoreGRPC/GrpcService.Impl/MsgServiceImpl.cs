using System;
using GrpcService.Protocol;
using Snai.GrpcService.Protocol;
using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcService.Impl
{
    public class MsgServiceImpl : MsgService.MsgServiceBase
    {

        //协议方法实现

        public MsgServiceImpl()
        {
        }


        public override async Task<GetMsgSumReply> GetSum(GetMsgNumRequest request, ServerCallContext context)
        {
            var result = new GetMsgSumReply();

            result.Sum = request.Num1 + request.Num2;

            return result;
        }



    }
}
