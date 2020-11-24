using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class StudentDemoesController : Controller
    {
        private ModelStudentLoginContainer db = new ModelStudentLoginContainer();

        // GET: StudentDemoes
        public ActionResult Index()
        {
            return View(db.StudentDemoes.ToList());
        }

        // GET: StudentDemoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentDemo studentDemo = db.StudentDemoes.Find(id);
            if (studentDemo == null)
            {
                return HttpNotFound();
            }
            return View(studentDemo);
        }

        // GET: StudentDemoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentDemoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,City")] StudentDemo studentDemo)
        {
            if (ModelState.IsValid)
            {
                db.StudentDemoes.Add(studentDemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentDemo);
        }

        // GET: StudentDemoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentDemo studentDemo = db.StudentDemoes.Find(id);
            if (studentDemo == null)
            {
                return HttpNotFound();
            }
            return View(studentDemo);
        }

        // POST: StudentDemoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,City")] StudentDemo studentDemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentDemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentDemo);
        }

        // GET: StudentDemoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentDemo studentDemo = db.StudentDemoes.Find(id);
            if (studentDemo == null)
            {
                return HttpNotFound();
            }
            return View(studentDemo);
        }

        // POST: StudentDemoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentDemo studentDemo = db.StudentDemoes.Find(id);
            db.StudentDemoes.Remove(studentDemo);
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
