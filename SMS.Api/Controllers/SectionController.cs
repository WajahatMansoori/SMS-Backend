using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.Common.Base;
using SMS.Application.Common.Helper;
using SMS.Application.Section.Commands.CreateSection;
using SMS.Application.Section.Commands.DeleteSection;
using SMS.Application.Section.Commands.UpdateSection;
using SMS.Application.Section.Queries.GetSection;
using SMS.Application.Section.Queries.GetSectionById;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ApiControllerBase
    {
        [HttpGet("get-all-section")]
        public async Task<BaseResponse<List<SectionVm>>> GetAllAsync()
        {
            //var sectionData = await Mediator.Send(new GetSectionQuery());
            //if(sectionData==null)
            //{
            //    var errorResponse = new BaseResponse<IEnumerable<SectionVm>>(false, "404", "Data not found", null);
            //    return errorResponse;
            //}
            //var response= new BaseResponse<IEnumerable<SectionVm>>(true,"200","Success",sectionData);
            //return response;
            return await GenerateResponseHelper.SendResponse(new GetSectionQuery(), Mediator);
        }

        [HttpGet("get-section-by-id")]
        public async Task<BaseResponse<SectionVm>> GetById(int id)
        {
            var query = new GetSectionByIdQuery { SectionId = id };
            return await GenerateResponseHelper.SendResponse(query, (Mediator)Mediator);
        }

        [HttpPost("add-section")]
        public async Task<BaseResponse<bool>> addAsync(CreateSectionCommand command)
        {
            return await GenerateResponseHelper.SendResponse(command, Mediator);
        }

        [HttpPost("update-section")]
        public async Task<BaseResponse<bool>> updateAsync(UpdateSectionCommand command)
        {
            return await GenerateResponseHelper.SendResponse(command, Mediator);
        }
        
        [HttpPost("delete-section")]
        public async Task<BaseResponse<bool>> deleteAsync(DeleteSectionCommand command)
        {
            return await GenerateResponseHelper.SendResponse(command, Mediator);
        }

    }
}
