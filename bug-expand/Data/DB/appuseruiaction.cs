using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class appuseruiaction
    {
        public string UserId { get; set; }
        public int UIActionId { get; set; }
        public int? PermisionId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual apppermission Permision { get; set; }
        public virtual uiaction UIAction { get; set; }
        public virtual aspnetusers User { get; set; }
    }
}
