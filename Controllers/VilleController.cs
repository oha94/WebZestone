using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebZstone.Models;

namespace WebZstone.Controllers
{
    public class VilleController : Controller
    {
        MyDbContext db;
        public VilleController(MyDbContext con)
        {
            db = con;
        }
        // GET: VilleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VilleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        // GET: VilleController/Create
        public ActionResult Create()
        {
            return View();
        }

            
        [HttpPost]
       

        public int Creates ([FromBody] object ob)
        {
            Ville v = JsonConvert.DeserializeObject<Ville>(ob.ToString());
            db.DbsVille.Add(v);
            db.SaveChanges();
            return 1;

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        //public ActionResult Creates(Ville v)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.DbsVille.Add(v);
        //        db.SaveChanges();
        //        return RedirectToAction("Listing");
        //    }
        //    return NotFound();

        //}

        [HttpGet]
        public ActionResult Listing()
        {
            var L = db.DbsVille.ToList().OrderBy(x => x.Lib);
            return View(L);

        }



        // POST: VilleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VilleController/Edit/5
        public ActionResult Edit(int id)
        {
            var v = db.DbsVille.Find(id);
            if (v == null) {
                return NotFound();
            }

            return View(v);
        }

        // POST: VilleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ville v )
        {
            if (ModelState.IsValid)
            {
                db.DbsVille.Update(v);
                db.SaveChanges();
                return RedirectToAction("Listing");

            }
            return NotFound();
        }

        // GET: VilleController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
          
                var v = db.DbsVille.Find(id);
                if (v == null)
                {
                    return NotFound();
                }
                db.DbsVille.Remove(v);
                db.SaveChanges();
                return RedirectToAction("Listing");
        }

        
    }
}
