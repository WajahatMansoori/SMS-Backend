using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Domain.Repository;

namespace SMS.Application.Class.Commands.DeleteClass
{
    public class DeleteClassCommandHandler : IRequestHandler<DeleteClassCommand, bool>
    {
        private IClassRepository _classRepository;

        public DeleteClassCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<bool> Handle(DeleteClassCommand request, CancellationToken cancellationToken)
        {
           var result= await _classRepository.DeleteClassAsync(request.ClassId);
            if (result == null)
                return false;
            return true;
        }
    }
}
