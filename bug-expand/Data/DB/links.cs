using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class links
    {
        public links()
        {
            InverseParent = new HashSet<links>();
        }

        public int Id { get; set; }
        public int? Position { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string IconImageUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public int? PageId { get; set; }
        public int? MenuId { get; set; }

        public virtual menus Menu { get; set; }
        public virtual pages Page { get; set; }
        public virtual links Parent { get; set; }
        public virtual ICollection<links> InverseParent { get; set; }
    }
}
