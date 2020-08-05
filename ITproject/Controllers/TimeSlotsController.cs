using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITproject.Models;

namespace ITproject.Controllers
{
    public class TimeSlotsController : Controller
    {
        private ITprojectContext db = new ITprojectContext();

        // GET: TimeSlots
        public ActionResult Index()
        {
            return View(db.TimeSlots.ToList());
        }

        // GET: TimeSlots/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeSlot timeSlot = db.TimeSlots.Find(id);
            if (timeSlot == null)
            {
                return HttpNotFound();
            }
            return View(timeSlot);
        }

        // GET: TimeSlots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeSlots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Slot,TimeSlotStatus")] TimeSlot timeSlot)
        {
            if (ModelState.IsValid)
            {
                db.TimeSlots.Add(timeSlot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timeSlot);
        }

        // GET: TimeSlots/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeSlot timeSlot = db.TimeSlots.Find(id);
            if (timeSlot == null)
            {
                return HttpNotFound();
            }
            return View(timeSlot);
        }

        // POST: TimeSlots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Slot,TimeSlotStatus")] TimeSlot timeSlot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeSlot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeSlot);
        }

        // GET: TimeSlots/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeSlot timeSlot = db.TimeSlots.Find(id);
            if (timeSlot == null)
            {
                return HttpNotFound();
            }
            return View(timeSlot);
        }

        // POST: TimeSlots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            TimeSlot timeSlot = db.TimeSlots.Find(id);
            db.TimeSlots.Remove(timeSlot);
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
