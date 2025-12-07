using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.Section.Commands.UpdateSection
{
    public class UpdateSectionCommandHandler : IRequestHandler<UpdateSectionCommand, bool>
    {
        private readonly ISectionRepository _sectionRepository;
        public UpdateSectionCommandHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<bool> Handle(UpdateSectionCommand request, CancellationToken cancellationToken)
        {
            var SectionObj= new SMS.Domain.Entity.Section
            {
                SectionName=request.SectionName
            };
            var Section = await _sectionRepository.UpdateSection(request.SectionId, SectionObj);
            if (Section == null)
                return false;
            return true;
        }
    }
}
