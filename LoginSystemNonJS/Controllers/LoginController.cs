﻿using LoginSystemNonJS.Database;
using LoginSystemNonJS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LoginSystemNonJS.Controllers
{
    public class LoginController : Controller
    {
        public readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            // Koppling till vår databas.
            _context = context;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET
        public async Task<IActionResult> Login([FromBody] User user)
        {
            if (await CheckLogin(user))
            {
                return Ok();
            }
            return Unauthorized();
        }

        // GET
        public async Task<bool> CheckLogin(User user)
        {
            return await _context.users.AnyAsync(x => x.Username == user.Username && x.Password == user.Password);
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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