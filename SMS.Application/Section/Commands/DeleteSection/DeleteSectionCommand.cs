using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Section.Commands.DeleteSection
{
    public class DeleteSectionCommand:IRequest<bool>
    {
        public int SectionId { get; set; }
    }
}
