﻿using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class aspnetusertokens
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual aspnetusers User { get; set; }
    }
}
