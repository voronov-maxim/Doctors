using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class apppermission
    {
        public apppermission()
        {
            approlesuiactions = new HashSet<approlesuiactions>();
            appuseruiaction = new HashSet<appuseruiaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }

        public virtual ICollection<approlesuiactions> approlesuiactions { get; set; }
        public virtual ICollection<appuseruiaction> appuseruiaction { get; set; }
    }
}
