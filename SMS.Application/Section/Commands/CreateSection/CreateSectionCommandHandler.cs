using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Section.Queries.GetSection;
using SMS.Domain.Entity;
using SMS.Domain.Repository;

namespace SMS.Application.Section.Commands.CreateSection
{
    public class CreateSectionCommandHandler : IRequestHandler<CreateSectionCommand, bool>
    {
        private ISectionRepository _sectionRepository;
        public CreateSectionCommandHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<bool> Handle(CreateSectionCommand request, CancellationToken cancellationToken)
        {
            var sectionRequest = new SMS.Domain.Entity.Section
            {
                SectionName = request.SectioName
            };
            var section = await _sectionRepository.AddSection(sectionRequest);
            return true;
        }
    }
}
