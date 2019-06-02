using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class chatuser
    {
        public chatuser()
        {
            chatgroupusers = new HashSet<chatgroupusers>();
            chatmessage = new HashSet<chatmessage>();
            chatmessagelastread = new HashSet<chatmessagelastread>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public DateTime? LastActiveAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public int? LastReadMessageQId { get; set; }

        public virtual ICollection<chatgroupusers> chatgroupusers { get; set; }
        public virtual ICollection<chatmessage> chatmessage { get; set; }
        public virtual ICollection<chatmessagelastread> chatmessagelastread { get; set; }
    }
}
