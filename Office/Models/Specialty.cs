using System.Collections.Generic;

namespace Office.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.JoinEntries = new HashSet<DoctorPatientSpecialty>();
    }

    public int SpecialtyId { get; set; }
    public string SpecialtyName { get; set; }
    public ICollection<DoctorPatientSpecialty> JoinEntries { get; set; }
  }
}