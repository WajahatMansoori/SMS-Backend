using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.Class.Commands.UpdateClass
{
    public class UpdateClassCommandHandler : IRequestHandler<UpdateClassCommand, bool>
    {
        private readonly IClassRepository _classRepository;
        public UpdateClassCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<bool> Handle(UpdateClassCommand request, CancellationToken cancellationToken)
        {
            var ClassObj= new SMS.Domain.Entity.Class();
            ClassObj.ClassName=request.ClassName;
            var result= await _classRepository.UpdateClassAsync(request.ClassId, ClassObj);
            if (result == null)
                return false;
           return true;
        }
    }
}
