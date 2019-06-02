using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class aspnetusers
    {
        public aspnetusers()
        {
            appuseruiaction = new HashSet<appuseruiaction>();
            aspnetuserclaims = new HashSet<aspnetuserclaims>();
            aspnetuserlogins = new HashSet<aspnetuserlogins>();
            aspnetuserroles = new HashSet<aspnetuserroles>();
            aspnetusertokens = new HashSet<aspnetusertokens>();
            clientappointments = new HashSet<clientappointments>();
            mediaresource = new HashSet<mediaresource>();
            mediasharetouser = new HashSet<mediasharetouser>();
            userchildren = new HashSet<userchildren>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public int? GroupId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CNP { get; set; }

        public virtual group Group { get; set; }
        public virtual ICollection<appuseruiaction> appuseruiaction { get; set; }
        public virtual ICollection<aspnetuserclaims> aspnetuserclaims { get; set; }
        public virtual ICollection<aspnetuserlogins> aspnetuserlogins { get; set; }
        public virtual ICollection<aspnetuserroles> aspnetuserroles { get; set; }
        public virtual ICollection<aspnetusertokens> aspnetusertokens { get; set; }
        public virtual ICollection<clientappointments> clientappointments { get; set; }
        public virtual ICollection<mediaresource> mediaresource { get; set; }
        public virtual ICollection<mediasharetouser> mediasharetouser { get; set; }
        public virtual ICollection<userchildren> userchildren { get; set; }
    }
}
