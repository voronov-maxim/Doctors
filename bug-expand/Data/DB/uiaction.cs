using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class uiaction
    {
        public uiaction()
        {
            approlesuiactions = new HashSet<approlesuiactions>();
            appuseruiaction = new HashSet<appuseruiaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }

        public virtual ICollection<approlesuiactions> approlesuiactions { get; set; }
        public virtual ICollection<appuseruiaction> appuseruiaction { get; set; }
    }
}
