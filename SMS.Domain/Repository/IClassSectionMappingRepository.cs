using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Domain.Entity;

namespace SMS.Domain.Repository
{
    public interface IClassSectionMappingRepository
    {
        Task<bool> AddClassSectionMapping(ClassSectionMapping classSectionMapping);
        //Task<List<>>
    }
}
