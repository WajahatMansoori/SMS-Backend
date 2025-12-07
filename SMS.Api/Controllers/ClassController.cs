using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.Class.Commands.CreateClass;
using SMS.Application.Class.Commands.DeleteClass;
using SMS.Application.Class.Commands.UpdateClass;
using SMS.Application.Class.Queries.GetClass;
using SMS.Application.Class.Queries.GetClassById;
using SMS.Application.Common.Base;
using SMS.Application.Common.Helper;
using SMS.Domain.Entity;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ApiControllerBase
    {
        [HttpGet("get-all-class")]
        public async Task<BaseResponse<List<ClassVm>>> GetAllAsync()
        {
            return await GenerateResponseHelper.SendResponse(new GetClassQuery(), Mediator);

        }

        [HttpGet("get-class-by-id")]
        public async Task<BaseResponse<ClassVm>> GetClassByIdAsync(int id)
        {
            return await GenerateResponseHelper.SendResponse(new GetClassByIdQuery() { ClassId=id}, Mediator);
        }

        [HttpPost("add-class")]
        public async Task<BaseResponse<bool>> AddClass(CreateClassCommand command)
        {
            return await GenerateResponseHelper.SendResponse(command, Mediator);
        }

        [HttpPost("update-class")]
        public async Task<BaseResponse<bool>> UpdateClass(UpdateClassCommand command)
        {
            return await GenerateResponseHelper.SendResponse(command, Mediator);
        }

        [HttpPost("delete-class")]
        public async Task<BaseResponse<bool>> DeleteClass(DeleteClassCommand command)
        {
            return await GenerateResponseHelper.SendResponse(command, Mediator);
        }

    }
}
