using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Common.Base;

namespace SMS.Application.Common.Helper
{
    public static class GenerateResponseHelper
    {
        //public static async Task<BaseResponse<T>> SendResponse<T>(IRequest<T> request, Mediator mediator)
        public static async Task<BaseResponse<T>> SendResponse<T>(IRequest<T> request, ISender mediator)
        {
            var result = await mediator.Send(request);

            if (result == null || (result is bool b && !b))
            {
                return new BaseResponse<T>(
                    success: false,
                    code: "404",
                    message: "Data not found",
                    data: default
                );
            }

            return new BaseResponse<T>(
                success: true,
                code: "200",
                message: "Success",
                data: result
            );
        }

    }
}
