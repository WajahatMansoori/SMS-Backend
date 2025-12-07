using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Section.Commands.CreateSection
{
    public class CreateSectionCommand:IRequest<bool>
    {
        public string SectioName { get; set; }
    }
}
