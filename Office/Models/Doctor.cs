using System.Collections.Generic;
using System;

namespace Office.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntries = new HashSet<DoctorPatientSpecialty>();
    }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }

    public ICollection<DoctorPatientSpecialty> JoinEntries { get; set; }
  }
}