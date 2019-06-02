using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class aspnetroleclaims
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual aspnetroles Role { get; set; }
    }
}
