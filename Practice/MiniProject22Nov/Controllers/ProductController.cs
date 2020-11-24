using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MiniProject22Nov.Models;

namespace MiniProject22Nov.Controllers
{
    public class ProductController : Controller
    {
        private MyDbEntities db = new MyDbEntities();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.Product_pro.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_pro product_pro = db.Product_pro.Find(id);
            if (product_pro == null)
            {
                return HttpNotFound();
            }
            return View(product_pro);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Product_pro product_pro)
        {
            

            if (ModelState.IsValid)
            {
               db.Product_pro.Add(product_pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product_pro);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_pro product_pro = db.Product_pro.Find(id);
            if (product_pro == null)
            {
                return HttpNotFound();
            }
            return View(product_pro);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Image,Product_number,Brand")] Product_pro product_pro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_pro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product_pro);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_pro product_pro = db.Product_pro.Find(id);
            if (product_pro == null)
            {
                return HttpNotFound();
            }
            return View(product_pro);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product_pro product_pro = db.Product_pro.Find(id);
            db.Product_pro.Remove(product_pro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbluser tuser) {
            var res = (from v in db.tblusers
                       where v.UserName == tuser.UserName && v.Password == tuser.Password
                       select v).FirstOrDefault<tbluser>();
            if (res != null)
            {
                string x = Session.SessionID;
                Session["UserName"] = res.UserName;
                TempData["k"] = x;
                return RedirectToAction("Search");
            }
            else {
                ViewBag.invaliduser = "Invalid User";
                return View();
            }
        }
        public ActionResult Logout()
        {

            Session.Abandon();
            return RedirectToAction("Login");

        }

        [HttpGet]
        public ActionResult Search()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult Search(string pname)
        {
            var result = from rng in db.Product_pro where rng.Name == pname select rng;
            return View("Display", result);
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
