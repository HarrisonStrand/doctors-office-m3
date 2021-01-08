using System.Collections.Generic;

namespace Office.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinEntries = new HashSet<DoctorPatientSpecialty>();
    }

    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public string DOB { get; set; }

    public ICollection<DoctorPatientSpecialty> JoinEntries { get; set; }
  }
}