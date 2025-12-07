using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Common.Base
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public BaseResponse(bool success, string code, string message, T data)
        {
            Success = success;
            Code = code;
            Message = message;
            Data = data;
        }
    }
}
