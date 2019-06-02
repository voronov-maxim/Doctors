using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class aspnetuserlogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }

        public virtual aspnetusers User { get; set; }
    }
}
