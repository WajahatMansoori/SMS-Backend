using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Class.Queries.GetClass
{
    public class GetClassQuery : IRequest<List<ClassVm>>
    {
    }
    //public record GetClassQuery:IRequest<List<ClassVm>>;
}
