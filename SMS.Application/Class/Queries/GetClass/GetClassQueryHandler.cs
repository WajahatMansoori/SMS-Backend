using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.Class.Queries.GetClass
{
    public class GetClassQueryHandler : IRequestHandler<GetClassQuery, List<ClassVm>>
    {
        private readonly IClassRepository _classRepository;

        public GetClassQueryHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<List<ClassVm>> Handle(GetClassQuery request, CancellationToken cancellationToken)
        {
            var Class = await _classRepository.GetAllClassAsync();
            if (Class == null)
                return null;

           var ClassList= Class.Select(x => new ClassVm()
            {
                ClassId = x.ClassId,
                ClassName = x.ClassName

            }).ToList();
            return ClassList;
            
        }
    }
}
