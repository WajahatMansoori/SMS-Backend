using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SMS.Application.Class.Queries.GetClass;
using SMS.Domain.Repository;

namespace SMS.Application.Class.Commands.CreateClass
{
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, bool>
    {
        private readonly IClassRepository _classRepository;

        public CreateClassCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<bool> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            
            var ClassRequest = new SMS.Domain.Entity.Class();
            ClassRequest.ClassName = request.ClassName;
            await _classRepository.AddClassAsync(ClassRequest);
            return true;
        }
    }
}
