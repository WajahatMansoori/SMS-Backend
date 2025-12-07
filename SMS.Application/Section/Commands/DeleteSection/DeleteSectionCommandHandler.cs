using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.Section.Commands.DeleteSection
{
    public class DeleteSectionCommandHandler : IRequestHandler<DeleteSectionCommand, bool>
    {
        private ISectionRepository _sectionRepository;
        public DeleteSectionCommandHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<bool> Handle(DeleteSectionCommand request, CancellationToken cancellationToken)
        {
            var section = await _sectionRepository.DeleteSection(request.SectionId);
            if (section == null)
                return false;
            return true;
        }
    }
}
