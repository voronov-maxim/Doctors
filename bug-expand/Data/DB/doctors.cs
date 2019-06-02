using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class doctors
    {
        public doctors()
        {
            clientappointments = new HashSet<clientappointments>();
            departmentdoctors = new HashSet<departmentdoctors>();
            doctorschedules = new HashSet<doctorschedules>();
            doctorschedulesexceptions = new HashSet<doctorschedulesexceptions>();
            doctorspecializations = new HashSet<doctorspecializations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Content { get; set; }
        public string UId { get; set; }
        public string TitleLine { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual ICollection<clientappointments> clientappointments { get; set; }
        public virtual ICollection<departmentdoctors> departmentdoctors { get; set; }
        public virtual ICollection<doctorschedules> doctorschedules { get; set; }
        public virtual ICollection<doctorschedulesexceptions> doctorschedulesexceptions { get; set; }
        public virtual ICollection<doctorspecializations> doctorspecializations { get; set; }
    }
}
