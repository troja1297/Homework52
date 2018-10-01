using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models;
using MyFirstMVC.ViewModels;

namespace MyFirstMVC.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: Phones/Create
        public IActionResult Index()
        {
            ViewData["Rating"] = new SelectList(_context.Categories, "Id");
            return View();
        }

        // POST: Phones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id,Name,Company,Price,CategoryId,AssemblyDate")] Phone phone)
        {   
            List<Phone> companies = _context.Phones.ToList();

            foreach (Phone phone1 in companies)
            {
                if (phone1.Name == phone.Name)
                {
                    ModelState.AddModelError("Name", "Такое имя уже существует");
                }
            }
            
            if (phone.AssemblyDate > DateTime.Now)
            {
                ModelState.AddModelError("AssemblyDate", "Телефон не может быть создан в будущем");
            }
            
            if (ModelState.IsValid)
            {
                _context.Add(phone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phone);
        }


       
    }
}

    