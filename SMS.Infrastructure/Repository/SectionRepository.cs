using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMS.Domain.Entity;
using SMS.Domain.Repository;
using SMS.Infrastructure.Data;

namespace SMS.Infrastructure.Repository
{
    public class SectionRepository : ISectionRepository
    {
        private SmsDbContext _context;
        public SectionRepository(SmsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddSection(Section section)
        {
             _context.Sections.Add(section);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSection(int sectionId)
        {
            var Existingsection = await _context.Sections.AsNoTracking().Where(x => x.IsActive == true && x.SectionId == sectionId).FirstOrDefaultAsync();
            if (Existingsection == null)
                return false;
            Existingsection.IsActive = false;
            _context.Sections.Update(Existingsection);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Section>> GetAllSection()
        {
            var sectionList = await _context.Sections.AsNoTracking().Where(x => x.IsActive).ToListAsync();
            return sectionList;
        }

        public async Task<Section> GetSectionById(int id)
        {
            var section = await _context.Sections.AsNoTracking().Where(x => x.IsActive && x.SectionId == id).FirstOrDefaultAsync();
            return section;
        }

        public async Task<bool> UpdateSection(int sectionId, Section section)
        {
            var Existing = await _context.Sections.AsNoTracking().Where(x => x.IsActive && x.SectionId == sectionId).FirstOrDefaultAsync();
            if (Existing == null)
                return false;
            Existing.SectionName = section.SectionName;
            _context.Sections.Update(Existing);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
