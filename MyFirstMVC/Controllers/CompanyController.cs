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
    public class CompaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET
        public ActionResult Index()
        {
            IEnumerable<Company> companies = _context.Companies.OrderBy(s => s.Name);
            return View(companies);
        }
        
        // GET: Phones/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Phones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,FoundationDate")] Company company)
        {
            List<Company> companies = _context.Companies.ToList();

            foreach (Company company1 in companies)
            {
                if (company.Name == company1.Name)
                {
                    ModelState.AddModelError("Name", "Такое имя ужесуществует");
                }
            }
            
            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }
    }
}