using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Section.Queries.GetSection;

namespace SMS.Application.Section.Queries.GetSectionById
{
    public class GetSectionByIdQuery:IRequest<SectionVm>
    {
        public int SectionId { get; set; }
    }
}
