using doan_asp.net.Data;
using doan_asp.net.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_asp.net.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            List<User> u = _db.Users.ToList();
            for (int i = 0; i < u.Count<User>(); i++)
            {
                if (u[i].username.Equals(username) && u[i].password.Equals(password))
                    return RedirectToAction(nameof(TintucController.Index), "Tintuc");

            }
            return NotFound();
        }
    }
}
