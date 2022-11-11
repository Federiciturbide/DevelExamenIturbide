using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenEncuestasDevel;

namespace ExamenEncuestasDevel.Controllers
{
    public class CamposController : Controller
    {
        private DBDevelEntities1 db = new DBDevelEntities1();

        // GET: Campos
        public ActionResult Index()
        {
            return View(db.Campos.ToList());
        }

        // GET: Campos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campos campos = db.Campos.Find(id);
            if (campos == null)
            {
                return HttpNotFound();
            }
            return View(campos);
        }

        // GET: Campos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEncuesta,Nombre,Titulo,Requerido,Tipo")] Campos campos)
        {
            if (ModelState.IsValid)
            {
                db.Campos.Add(campos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(campos);
        }

        // GET: Campos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campos campos = db.Campos.Find(id);
            if (campos == null)
            {
                return HttpNotFound();
            }
            return View(campos);
        }

        // POST: Campos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEncuesta,Nombre,Titulo,Requerido,Tipo")] Campos campos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campos);
        }

        // GET: Campos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campos campos = db.Campos.Find(id);
            if (campos == null)
            {
                return HttpNotFound();
            }
            return View(campos);
        }

        // POST: Campos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Campos campos = db.Campos.Find(id);
            db.Campos.Remove(campos);
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
