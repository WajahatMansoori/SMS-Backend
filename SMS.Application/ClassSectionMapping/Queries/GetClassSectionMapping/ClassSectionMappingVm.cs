using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.ClassSectionMapping.Queries.GetClassSectionMapping
{
    public class ClassSectionMappingVm
    {
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public int SectionId { get; set; }
        public string? SectionName { get; set; }
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public int TotalStudent { get; set; }
    }
}
