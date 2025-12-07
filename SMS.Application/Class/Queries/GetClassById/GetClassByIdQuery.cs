using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Class.Queries.GetClass;

namespace SMS.Application.Class.Queries.GetClassById
{
    public class GetClassByIdQuery:IRequest<ClassVm>
    {
        public int ClassId { get; set; }
    }
}
