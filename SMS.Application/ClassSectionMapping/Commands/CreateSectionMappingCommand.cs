using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SMS.Application.ClassSectionMapping.Commands
{
    public class CreateSectionMappingCommand:IRequest<bool>
    {
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int TotalStudent { get; set; }
        public int TeacherId { get; set; }
    }
}
