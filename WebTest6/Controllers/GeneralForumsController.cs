using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebTest6.Models;

namespace WebTest6.Controllers
{
    public class GeneralForumsController : Controller
    {
        private ForumDBContext db = new ForumDBContext();

        // GET: GeneralForums
        public ActionResult Index()
        {
            return View(db.Messages.ToList());
        }

        // GET: GeneralForums/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneralForum generalForum = db.Messages.Find(id);
            if (generalForum == null)
            {
                return HttpNotFound();
            }
            return View(generalForum);
        }

        // GET: GeneralForums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneralForums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,theMessage")] GeneralForum generalForum)
        {
            if (ModelState.IsValid)
            {
                db.Messages.Add(generalForum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(generalForum);
        }

        // GET: GeneralForums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneralForum generalForum = db.Messages.Find(id);
            if (generalForum == null)
            {
                return HttpNotFound();
            }
            return View(generalForum);
        }

        // POST: GeneralForums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,theMessage")] GeneralForum generalForum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(generalForum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(generalForum);
        }

        // GET: GeneralForums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneralForum generalForum = db.Messages.Find(id);
            if (generalForum == null)
            {
                return HttpNotFound();
            }
            return View(generalForum);
        }

        // POST: GeneralForums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GeneralForum generalForum = db.Messages.Find(id);
            db.Messages.Remove(generalForum);
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
