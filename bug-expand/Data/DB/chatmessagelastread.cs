using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class chatmessagelastread
    {
        public string GroupId { get; set; }
        public string UserId { get; set; }
        public int? LastQId { get; set; }

        public virtual chatgroup Group { get; set; }
        public virtual chatuser User { get; set; }
    }
}
