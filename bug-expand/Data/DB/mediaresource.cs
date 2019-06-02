using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class mediaresource
    {
        public mediaresource()
        {
            InverseParent = new HashSet<mediaresource>();
            mediasharetogroup = new HashSet<mediasharetogroup>();
            mediasharetouser = new HashSet<mediasharetouser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public float? Size { get; set; }
        public int? MediaType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public int? ParentId { get; set; }

        public virtual aspnetusers CreatedByNavigation { get; set; }
        public virtual mediaresource Parent { get; set; }
        public virtual ICollection<mediaresource> InverseParent { get; set; }
        public virtual ICollection<mediasharetogroup> mediasharetogroup { get; set; }
        public virtual ICollection<mediasharetouser> mediasharetouser { get; set; }
    }
}
