using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Class.Queries.GetClass;
using SMS.Domain.Repository;

namespace SMS.Application.Class.Queries.GetClassById
{
    public class GetClassByIdQueryHandler : IRequestHandler<GetClassByIdQuery, ClassVm>
    {
        private readonly IClassRepository _classRepository;
        
        public GetClassByIdQueryHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<ClassVm> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            var Data = await _classRepository.GetClassById(request.ClassId);
            if (Data == null)
                return null;

            var ClassData = new ClassVm
            {
                ClassId = Data.ClassId,
                ClassName = Data.ClassName
            };
            return ClassData;
        }
    }
}
