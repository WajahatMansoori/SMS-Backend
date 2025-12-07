using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.Class.Commands.CreateClass;
using SMS.Application.Class.Commands.DeleteClass;
using SMS.Application.Class.Commands.UpdateClass;
using SMS.Application.Class.Queries.GetClass;
using SMS.Application.Class.Queries.GetClassById;
using SMS.Application.Common.Base;
using SMS.Domain.Entity;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ApiControllerBase
    {
        [HttpGet("get-all-class")]
        public async Task<IActionResult> GetAllAsync()
        {
            var Class = await Mediator.Send(new GetClassQuery());
            if (Class == null)
                return GenerateBaseResponse("404", "No classes found.");
            var response = new BaseResponse<IEnumerable<ClassVm>>(
            true, "200", "Classes retrieved successfully.", Class);

            return GenerateResponse(response);

        }

        [HttpGet("get-class-by-id")]
        public async Task<BaseResponse<ClassVm>> GetClassByIdAsync(int id)
        {
            var ClassData = await Mediator.Send(new GetClassByIdQuery() { ClassId = id });
            if(ClassData == null)
            {
                var ErrorResponse = new BaseResponse<ClassVm>(false, "404", "Data not Found", ClassData);
                return ErrorResponse;
            }
            var response = new BaseResponse<ClassVm>(true,"200","Success",ClassData);
            return response;
        }

        [HttpPost("add-class")]
        public async Task<BaseResponse<CreateClassCommand>> AddClass(CreateClassCommand command)
        {
            var CreatedClass = await Mediator.Send(command);
            var response = new BaseResponse<CreateClassCommand>(true, "200", "Success", null);
            return response;
        }

        [HttpPost("update-class")]
        public async Task<BaseResponse<UpdateClassCommand>> UpdateClass(UpdateClassCommand command)
        {
            var UpdatedClass = await Mediator.Send(command);
            if (!UpdatedClass)
            {
                var errorReponse = new BaseResponse<UpdateClassCommand>(false, "400", "Bad request", null);
                return errorReponse;
            }
            var response = new BaseResponse<UpdateClassCommand>(true, "200", "success", null);
            return response;
        }

        [HttpPost("delete-class")]
        public async Task<BaseResponse<DeleteClassCommand>> DeleteClass(DeleteClassCommand command)
        {
            var DeleteClass= await Mediator.Send(command);
            if (!DeleteClass)
            {
                var errorResponse = new BaseResponse<DeleteClassCommand>(false, "400", "bad request", null);
                return errorResponse;
            }
            var response = new BaseResponse<DeleteClassCommand>(true, "200", "success", null);
            return response;
        }

    }
}
