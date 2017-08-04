using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CandyStore.Controllers
{
    public class ProductController : Controller
    {
        private CandyStoreContext db = new CandyStoreContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.ProducerId = new SelectList(db.Producers, "ProducerId", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }
    }
}
