using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Class.Commands.DeleteClass
{
    public class DeleteClassCommand:IRequest<bool>
    {
        public int ClassId { get; set; }
    }
}
