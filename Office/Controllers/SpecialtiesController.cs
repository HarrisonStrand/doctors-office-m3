using Microsoft.AspNetCore.Mvc;
using Office.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Office.Controllers
{
  public class SpecialtiesController : Controller
  {
    private readonly OfficeContext _db;
    public SpecialtiesController(OfficeContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Specialty> model = _db.Specialties.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "DoctorName", "Specialty");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Specialty specialty, int DoctorId)
    {

      _db.Specialties.Add(specialty);
      if (DoctorId != 0)
      {
        _db.DoctorPatientSpecialties.Add(new DoctorPatientSpecialty(){
          DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisSpecialty = _db.Specialties
      .Include(specialty => specialty.JoinEntries)
      .ThenInclude(specialty => specialty.Doctor)
      .FirstOrDefault(doctor => doctor.SpecialtyId == id);
      return View(thisSpecialty);
    }
    public ActionResult Edit(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialties => specialties.SpecialtyId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "DoctorName");
      ViewBag.PatientId = new SelectList(_db.Patients, "PatientId", "PatientName");
      return View(thisSpecialty);
    }

    [HttpPost]
    public ActionResult Edit(Specialty specialty, int DoctorId)
    {
      if (DoctorId != 0)
      {
        _db.DoctorPatientSpecialties.Add(new DoctorPatientSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
      }
      _db.Entry(specialty).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}