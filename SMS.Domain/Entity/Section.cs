using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entity
{
    public class Section
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; }
    }
}
