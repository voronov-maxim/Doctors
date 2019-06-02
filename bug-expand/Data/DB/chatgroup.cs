using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class chatgroup
    {
        public chatgroup()
        {
            chatgroupusers = new HashSet<chatgroupusers>();
            chatmessage = new HashSet<chatmessage>();
            chatmessagelastread = new HashSet<chatmessagelastread>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThumbImage { get; set; }
        public string Image { get; set; }
        public DateTime? LastActivityAt { get; set; }
        public string LastActivityBy { get; set; }
        public string LastMessageId { get; set; }
        public int? GroupType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public int? LastMessageQId { get; set; }

        public virtual chatmessage LastMessage { get; set; }
        public virtual ICollection<chatgroupusers> chatgroupusers { get; set; }
        public virtual ICollection<chatmessage> chatmessage { get; set; }
        public virtual ICollection<chatmessagelastread> chatmessagelastread { get; set; }
    }
}
