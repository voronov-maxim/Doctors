using System;
using System.Collections.Generic;

namespace GomoiuWeb.Shared.Data.DB
{
    public partial class Doctors
    {
        public Doctors()
        {
            ClientAppointments = new HashSet<ClientAppointments>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        //public string Content { get; set; }
        //public string UID { get; set; }
        //public string TitleLine { get; set; }
        //public string ProfilePicture { get; set; }
        //public DateTime? CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
        //public DateTime? DeletedAt { get; set; }
        //public string CreatedBy { get; set; }
        //public string UpdatedBy { get; set; }
        //public string DeletedBy { get; set; }

        public ICollection<ClientAppointments> ClientAppointments { get; set; }
    }
}
