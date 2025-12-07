using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.Section.Queries.GetSection
{
    public class GetSectionQueryHandler : IRequestHandler<GetSectionQuery, List<SectionVm>>
    {
        private readonly ISectionRepository _sectionRepository;
        public GetSectionQueryHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public async Task<List<SectionVm>> Handle(GetSectionQuery request, CancellationToken cancellationToken)
        {
            var SectionData = await _sectionRepository.GetAllSection();
            if (SectionData == null)
                return null;
            var sectionList = SectionData.Select(x => new SectionVm
            {
                SectionId = x.SectionId,
                SectionName = x.SectionName
            }).ToList();
            return sectionList;
        }
    }
}
