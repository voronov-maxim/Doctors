﻿using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class articlearticlecategories
    {
        public int ArticleId { get; set; }
        public int ArticleCategoryId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual articles Article { get; set; }
        public virtual articlecategories ArticleCategory { get; set; }
    }
}
