using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PPGrupo1.Models;

namespace PPGrupo1.Controllers
{
    public class MetodoPagosController : Controller
    {
        private FacturacionProdDbContext db = new FacturacionProdDbContext();

        // GET: MetodoPagos
        public ActionResult Index()
        {
            return View(db.MetodoPag.ToList());
        }

        // GET: MetodoPagos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetodoPago metodoPago = db.MetodoPag.Find(id);
            if (metodoPago == null)
            {
                return HttpNotFound();
            }
            return View(metodoPago);
        }

        // GET: MetodoPagos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetodoPagos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MetodoPagoId,Descripcion,CantidadDias,Activo")] MetodoPago metodoPago)
        {
            if (ModelState.IsValid)
            {
                db.MetodoPag.Add(metodoPago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metodoPago);
        }

        // GET: MetodoPagos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetodoPago metodoPago = db.MetodoPag.Find(id);
            if (metodoPago == null)
            {
                return HttpNotFound();
            }
            return View(metodoPago);
        }

        // POST: MetodoPagos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MetodoPagoId,Descripcion,CantidadDias,Activo")] MetodoPago metodoPago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metodoPago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metodoPago);
        }

        // GET: MetodoPagos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetodoPago metodoPago = db.MetodoPag.Find(id);
            if (metodoPago == null)
            {
                return HttpNotFound();
            }
            return View(metodoPago);
        }

        // POST: MetodoPagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MetodoPago metodoPago = db.MetodoPag.Find(id);
            db.MetodoPag.Remove(metodoPago);
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
