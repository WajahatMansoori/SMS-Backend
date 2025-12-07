using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Domain.Entity;

namespace SMS.Domain.Repository
{
    public interface ISectionRepository
    {
        Task<List<Section>> GetAllSection();
        Task<Section> GetSectionById(int id);
        Task<bool> AddSection(Section section);
        Task<bool> UpdateSection(int sectionId,Section section);
        Task<bool> DeleteSection(int sectionId);
    }
}
