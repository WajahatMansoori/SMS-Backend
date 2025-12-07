using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Section.Queries.GetSection;
using SMS.Domain.Repository;

namespace SMS.Application.Section.Queries.GetSectionById
{
    public class GetSectionByIdHandler : IRequestHandler<GetSectionByIdQuery, SectionVm>
    {
        private ISectionRepository _sectionRepository;
        public GetSectionByIdHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public async Task<SectionVm> Handle(GetSectionByIdQuery request, CancellationToken cancellationToken)
        {
            var section = await _sectionRepository.GetSectionById(request.SectionId);
            if (section == null)
                return null;

            var sectionData = new SectionVm
            {
                SectionId=section.SectionId,
                SectionName=section.SectionName
            };
            return sectionData;
        }
    }
}
