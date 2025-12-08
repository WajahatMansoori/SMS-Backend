using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.ClassSectionMapping.Commands
{
    public class CreateSectionMappingHandler : IRequestHandler<CreateSectionMappingCommand, bool>
    {
        private readonly IClassSectionMappingRepository _classSectionMappingRepository;
        public CreateSectionMappingHandler(IClassSectionMappingRepository classSectionMappingRepository)
        {
            _classSectionMappingRepository = classSectionMappingRepository;
        }
        public async Task<bool> Handle(CreateSectionMappingCommand request, CancellationToken cancellationToken)
        {
            var Mapping = new SMS.Domain.Entity.ClassSectionMapping
            {
                ClassId = request.ClassId,
                SectionId= request.SectionId,
                TeacherId = request.TeacherId,
                TotalStudent=request.TotalStudent
            };

            var result = await _classSectionMappingRepository.AddClassSectionMapping(Mapping);
            return result;
        }
    }
}
