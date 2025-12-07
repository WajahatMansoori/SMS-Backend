using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Class.Commands.UpdateClass
{
    public class UpdateClassCommand:IRequest<bool>
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
