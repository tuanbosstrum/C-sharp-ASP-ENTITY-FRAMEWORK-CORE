using doan_asp.net.Data;
using doan_asp.net.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_asp.net.Controllers
{
    public class TintucController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TintucController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Tintuc> objList = _db.News;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tintuc obj)
        {
            if (ModelState.IsValid)
            {
                _db.News.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(obj);
        }

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var b = _db.News.Find(id);
            if (b == null)
                return NotFound();
            else
                return View(b);

        }
        //POST - EDIT
        [HttpPost]
        public IActionResult Edit(Tintuc obj)
        {
            if (ModelState.IsValid)
            {

                _db.News.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET - DELETE
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
                return NotFound();
            var b = _db.News.Find(id);
            if (b == null) return NotFound();
            else return View(b);
        }
        //POST - DELETE
        [HttpPost]
        public IActionResult Delete(Tintuc obj)
        {
            _db.News.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET - DETAILS
        public IActionResult Details(int id)
        {
            if (id == null || id == 0)
                return NotFound();
            var b = _db.News.Find(id);
            if (b == null) return NotFound();
            else return View(b);
        }

        //Search- FILE
        public IActionResult Search(string term)
        {
            if (term == null)
                term = "";
            Tintuc[] cou = _db.News.Where(b => b.Tieude.ToLower().Contains(term.ToLower())).ToArray();
            return View("Index", cou);
        }


    }
}
