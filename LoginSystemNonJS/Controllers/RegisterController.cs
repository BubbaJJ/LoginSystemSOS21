using LoginSystemNonJS.Database;
using LoginSystemNonJS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginSystemNonJS.Controllers
{
    public class RegisterController : Controller
    {
        public readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            // Koppling till vår databas.
            _context = context;
        }

        // GET: RegisterController
        public ActionResult Index()
        {
            return View();
        }

        public class Input
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] Input input)
        {
            var user = new User
            {
                Username = input.Username,
                Password = input.Password
            };

            if (await ExistingUser(user))
            {
                return Conflict();
            }

            _context.users.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }

        public async Task<bool> ExistingUser(User user)
        {
            return await _context.users.AnyAsync(x => x.Username == user.Username);
        }

        // GET: RegisterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterController/Create
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

        // GET: RegisterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RegisterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}