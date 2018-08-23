using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CarInsurance.Models;

namespace MVC_CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        public InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.










        [HttpPost]
        public ActionResult Create(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, bool Dui, int SpeedingTickets, bool CoverageType)


        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress)

               || string.IsNullOrEmpty(CarMake) || string.IsNullOrEmpty(CarModel))
            {
                return View("~/Views/Insuree/Error.cshtml");
            }

            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {

                    var Quote = 50.00;
                    var quote = new Insuree();

                    quote.FirstName = FirstName;

                    quote.LastName = LastName;

                    quote.EmailAddress = EmailAddress;

                    quote.DateOfBirth = DateOfBirth;

                    quote.CarYear = CarYear;

                    quote.CarMake = CarMake;

                    quote.CarModel = CarModel;

                    quote.DUI = Dui;

                    quote.SpeedingTickets = SpeedingTickets;

                    quote.CoverageType = CoverageType;

                    quote.Quote = Convert.ToDecimal(Quote);


                    var today = DateTime.Now;
                    var insureeAge = today.Year - DateOfBirth.Year;
                    if (DateOfBirth > today.AddYears(-insureeAge)) insureeAge--;
                    if (insureeAge < 18 || insureeAge > 100)
                    {
                        Quote += 100;
                    }

                    if (CarYear < 2000 || CarYear > 2015)
                    {
                        Quote += 25;
                    }

                    if (CarMake.ToLower() == "porsche")
                    {
                        Quote += 25;
                    }
                    if (CarMake.ToLower() == "porsche" && (CarModel.ToLower() == "911 carrera"))
                    {
                        Quote += 25;
                    }
                    if (SpeedingTickets > 0)
                    {
                        Quote += (SpeedingTickets * 10);
                    }
                    if (Dui == true)
                    {
                        Quote = Quote * 1.25;
                    }
                    if (CoverageType == true)
                    {
                        Quote = Quote * 1.5;
                    }
                quote.Quote = Convert.ToDecimal(Quote);
                    ViewBag.quote = Quote;
                    db.Insurees.Add(quote);
                    db.SaveChanges();
                };
                return View("Quote");
            }
          
      
    }

    // GET: Insuree/Edit/5
    public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
