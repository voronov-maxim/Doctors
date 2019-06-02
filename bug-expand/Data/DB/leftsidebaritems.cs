using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class leftsidebaritems
    {
        public leftsidebaritems()
        {
            InverseParent = new HashSet<leftsidebaritems>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int? ParentId { get; set; }
        public int? Position { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string ro_Title { get; set; }
        public string Area { get; set; }
        public int? UIActionId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? GroupId { get; set; }

        public virtual group Group { get; set; }
        public virtual leftsidebaritems Parent { get; set; }
        public virtual ICollection<leftsidebaritems> InverseParent { get; set; }
    }
}
