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
    public class ClassRepository : IClassRepository
    {
        private readonly SmsDbContext _context;
        public ClassRepository(SmsDbContext context)
        {
            _context = context;
        }

        public async Task<Class> AddClassAsync(Class Class)
        {
            _context.Classes.Add(Class);
            await _context.SaveChangesAsync();
            return Class;
        }

        public async Task<Class> DeleteClassAsync(int ClassId)
        {
            var Existing = await _context.Classes.FindAsync(ClassId);
            if (Existing == null)
                return null;
            Existing.IsActive = false;
            _context.Classes.Update(Existing);
            await _context.SaveChangesAsync();
            return Existing;
        }

        public async Task<List<Class>> GetAllClassAsync()
        {
            return await _context.Classes.AsNoTracking().ToListAsync();
        }

        public async Task<Class> GetClassById(int ClassId)
        {
            return await _context.Classes.FindAsync(ClassId);
        }

        public async Task<Class> UpdateClassAsync(int ClassId, Class Class)
        {
            var Existing = await _context.Classes.FindAsync(ClassId);
            if (Existing == null)
                return null;
            Existing.ClassName = Class.ClassName;
            _context.Classes.Update(Existing);
            await _context.SaveChangesAsync();
            return Existing;
        }
    }
}
