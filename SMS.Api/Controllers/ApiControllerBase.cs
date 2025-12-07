using System.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.Common.Base;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ?? HttpContext.RequestServices.GetRequiredService<ISender>();

        protected IActionResult GenerateResponse<T>(BaseResponse<T> response)
        {
            HttpStatusCode statusCode;
            switch (response.Code)
            {
                case "400":
                    statusCode = HttpStatusCode.BadRequest;
                    break;
                case "404":
                    statusCode = HttpStatusCode.NotFound;
                    break;
                case "409":
                    statusCode = HttpStatusCode.Conflict;
                    break;
                case "401":
                    statusCode = HttpStatusCode.Unauthorized;
                    break;
                case "403":
                    statusCode = HttpStatusCode.Forbidden;
                    break;
                case "500":
                    statusCode = HttpStatusCode.InternalServerError;
                    break;
                default:
                    statusCode = HttpStatusCode.OK;
                    break;
            }

            return StatusCode((int)statusCode, response);
        }

        protected IActionResult GenerateBaseResponse(string code, string message)
        {
            return GenerateResponse(new  BaseResponse<object>(false, code, message, null));
        }
    }
}
