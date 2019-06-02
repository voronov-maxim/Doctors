using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class departments
    {
        public departments()
        {
            InverseParent = new HashSet<departments>();
            departmentdoctors = new HashSet<departmentdoctors>();
            departmentlocations = new HashSet<departmentlocations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; }
        public int? PageId { get; set; }
        public string IsMedical { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string Icon { get; set; }

        public virtual pages Page { get; set; }
        public virtual departments Parent { get; set; }
        public virtual ICollection<departments> InverseParent { get; set; }
        public virtual ICollection<departmentdoctors> departmentdoctors { get; set; }
        public virtual ICollection<departmentlocations> departmentlocations { get; set; }
    }
}
