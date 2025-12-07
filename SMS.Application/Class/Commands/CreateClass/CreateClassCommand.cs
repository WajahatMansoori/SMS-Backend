using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Class.Commands.CreateClass
{
    public class CreateClassCommand:IRequest<bool>
    {
        public string ClassName { get; set; }
    }
}
