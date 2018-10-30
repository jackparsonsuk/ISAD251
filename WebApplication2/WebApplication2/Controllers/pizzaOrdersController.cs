using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class pizzaOrdersController : Controller
    {
        private pizzaDB db = new pizzaDB();

        // GET: pizzaOrders
        public ActionResult Index()
        {
            return View(db.orders.ToList());
        }

        // GET: pizzaOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pizzaOrders pizzaOrders = db.orders.Find(id);
            if (pizzaOrders == null)
            {
                return HttpNotFound();
            }
            return View(pizzaOrders);
        }

        // GET: pizzaOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pizzaOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderID,order_Number,Quantity")] pizzaOrders pizzaOrders)
        {
            if (ModelState.IsValid)
            {
                db.orders.Add(pizzaOrders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pizzaOrders);
        }

        // GET: pizzaOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pizzaOrders pizzaOrders = db.orders.Find(id);
            if (pizzaOrders == null)
            {
                return HttpNotFound();
            }
            return View(pizzaOrders);
        }

        // POST: pizzaOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderID,order_Number,Quantity")] pizzaOrders pizzaOrders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pizzaOrders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizzaOrders);
        }

        // GET: pizzaOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pizzaOrders pizzaOrders = db.orders.Find(id);
            if (pizzaOrders == null)
            {
                return HttpNotFound();
            }
            return View(pizzaOrders);
        }

        // POST: pizzaOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pizzaOrders pizzaOrders = db.orders.Find(id);
            db.orders.Remove(pizzaOrders);
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
