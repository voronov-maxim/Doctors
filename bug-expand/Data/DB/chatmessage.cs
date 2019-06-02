using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class chatmessage
    {
        public chatmessage()
        {
            chatgroup = new HashSet<chatgroup>();
        }

        public string Id { get; set; }
        public int? ContentType { get; set; }
        public string Content { get; set; }
        public string ForwardSourceId { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public int? MediaResourceId { get; set; }
        public string SenderName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public int QId { get; set; }

        public virtual chatgroup Group { get; set; }
        public virtual chatuser User { get; set; }
        public virtual ICollection<chatgroup> chatgroup { get; set; }
    }
}
