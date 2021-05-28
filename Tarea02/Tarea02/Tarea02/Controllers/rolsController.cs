﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tarea02.Models;

namespace Tarea02.Controllers
{
    public class rolsController : Controller
    {
        private ncapasTarea2Entities db = new ncapasTarea2Entities();

        // GET: rols
        public ActionResult Index()
        {
            return View(db.rols.ToList());
        }

        // GET: rols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rol rol = db.rols.Find(id);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        // GET: rols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: rols/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,descrip,estado")] rol rol)
        {
            if (ModelState.IsValid)
            {
                db.rols.Add(rol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rol);
        }

        // GET: rols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rol rol = db.rols.Find(id);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        // POST: rols/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,descrip,estado")] rol rol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rol);
        }

        // GET: rols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rol rol = db.rols.Find(id);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        // POST: rols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            rol rol = db.rols.Find(id);
            db.rols.Remove(rol);
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
