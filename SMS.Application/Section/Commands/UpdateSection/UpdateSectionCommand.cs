using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.Section.Commands.UpdateSection
{
    public class UpdateSectionCommand:IRequest<bool>
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
    }
}
