using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyStore.Controllers
{
    public class ProducerController : Controller
    {
        private CandyStoreContext db = new CandyStoreContext();
        public IActionResult Index()
        {
            return View(db.Producers.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producer producer)
        {
            db.Producers.Add(producer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Producer thisProducer = db.Producers.FirstOrDefault(producers => producers.ProducerId == id);
            return View(thisProducer);
        }

        [HttpPost]
        public IActionResult Edit(Producer producer)
        {
            db.Entry(producer).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Producer thisProducer = db.Producers.FirstOrDefault(producers => producers.ProducerId == id);
            return View(thisProducer);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Producer thisProducer = db.Producers.FirstOrDefault(producers => producers.ProducerId == id);
            db.Producers.Remove(thisProducer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Producer thisProducer = db.Producers.Include(producers => producers.Products).FirstOrDefault(producers => producers.ProducerId == id);
            //Producer thisProducer = db.Producers.Include(producers => producers.Experiences).FirstOrDefault(locations => locations.ProducerId == id);
            return View(thisProducer);
        }
    }
}
