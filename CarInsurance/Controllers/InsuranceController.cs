using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsuranceController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insurances
        public ActionResult Index()
        {
            return View(db.Insurances.ToList());
        }

        // GET: Insurances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        // GET: Insurances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarMode,DUI,SpeedingTickets,CoverageType,Quote")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                int age = DateTime.Now.Year - insurance.DateOfBirth.Year;
                insurance.Quote = 50;
                if (age <= 18)
                {
                    insurance.Quote += 100;
                }
                if (age >= 19 &&  age <= 25)
                {
                    insurance.Quote += 50;
                }
                if (age > 25)
                {
                    insurance.Quote += 25;
                }
                int car = DateTime.Now.Year;
                if (insurance.CarYear < 2000)
                {
                    insurance.Quote += 25;
                }
                if (insurance.CarYear > 2015)
                {
                    insurance.Quote += 25;
                }
                if (insurance.CarMake == "porsche")
                {
                    insurance.Quote += 25;
                }
                if (insurance.CarMake == "porsche" && insurance.CarMode == "911 carrera")
                {
                    insurance.Quote += 25;
                }
                if (insurance.SpeedingTickets >= 1)
                {
                    int TicketsTotal = insurance.SpeedingTickets * 10;
                    insurance.Quote += TicketsTotal;
                }
                if (insurance.DUI)
                {
                    insurance.Quote *= 0.25m;
                }
                if (insurance.CoverageType)
                {
                    insurance.Quote *= 0.5m;
                }
                db.Insurances.Add(insurance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurance);
        }

        // GET: Insurances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        // POST: Insurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarMode,DUI,SpeedingTickets,CoverageType,Quote")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurance);
        }

        // GET: Insurances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        // POST: Insurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurance insurance = db.Insurances.Find(id);
            db.Insurances.Remove(insurance);
            db.SaveChanges();
            return RedirectToAction("Index");
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
