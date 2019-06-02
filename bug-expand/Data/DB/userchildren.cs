using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class userchildren
    {
        public userchildren()
        {
            clientappointments = new HashSet<clientappointments>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Valid { get; set; }
        public string CNP { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual aspnetusers User { get; set; }
        public virtual ICollection<clientappointments> clientappointments { get; set; }
    }
}
