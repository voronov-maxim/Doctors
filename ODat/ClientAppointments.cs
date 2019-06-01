using System;
using System.Collections.Generic;

namespace GomoiuWeb.Shared.Data.DB
{
    public partial class ClientAppointments
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public string Comments { get; set; }

        public Doctors Doctor { get; set; }
    }
}
