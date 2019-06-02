using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class chatgroupusers
    {
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual chatgroup Group { get; set; }
        public virtual chatuser User { get; set; }
    }
}
