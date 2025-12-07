using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Domain.Entity;

namespace SMS.Domain.Repository
{
    public interface IClassRepository
    {
        Task<List<Class>> GetAllClassAsync();
        Task<Class> GetClassById(int ClassId);
        Task<Class> AddClassAsync(Class Class);
        Task<Class> UpdateClassAsync(int ClassId,Class Class);
        Task<Class> DeleteClassAsync(int ClassId);
    }
}
