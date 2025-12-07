using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Section.Queries.GetSection
{
    public class GetSectionQuery:IRequest<List<SectionVm>>
    {
    }
}
