using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyVaccineInventory.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                using (SqlConnection ConnectionObject = new SqlConnection(PharmacyVaccineInventory.Properties.Resources.ConnectionString))
                {
                    ConnectionObject.Open();
                    using (SqlCommand CommandObject = new SqlCommand("SELECT * FROM dbo.Patient", ConnectionObject))
                    {
                        using (SqlDataReader dr = CommandObject.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                patients.Add(new Patient
                                {
                                    Id = dr.GetInt64(dr.GetOrdinal("Id")),
                                    FName = dr.GetString(dr.GetOrdinal("FName")),
                                    LName = dr.GetString(dr.GetOrdinal("LName")),
                                    DOB = dr.GetDateTime(dr.GetOrdinal("DOB")),
                                    phone = dr.GetInt64(dr.GetOrdinal("phone")),
                                    gender = dr.GetString(dr.GetOrdinal("gender"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(patients);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = new Patient();
            try
            {
                using (SqlConnection ConnectionObject = new SqlConnection(PharmacyVaccineInventory.Properties.Resources.ConnectionString))
                {
                    ConnectionObject.Open();
                    using (SqlCommand CommandObject = new SqlCommand("SELECT * FROM dbo.Patient WHERE Id = " + id, ConnectionObject))
                    {
                        using (SqlDataReader dr = CommandObject.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                patient.Id = dr.GetInt64(dr.GetOrdinal("Id"));
                                patient.FName = dr.GetString(dr.GetOrdinal("FName"));
                                patient.LName = dr.GetString(dr.GetOrdinal("LName"));
                                patient.DOB = dr.GetDateTime(dr.GetOrdinal("DOB"));
                                patient.phone = dr.GetInt64(dr.GetOrdinal("phone"));
                                patient.gender = dr.GetString(dr.GetOrdinal("gender"));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(patient);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


     
        
    }
}
