using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entity
{
    public class ClassSectionMapping
    {
        public int ClassSectionMappingId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int TotalStudent { get; set; }
        public int TeacherId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; }
    }
}
