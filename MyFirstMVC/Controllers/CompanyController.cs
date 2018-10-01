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
                    ModelState.AddModelError("Name", "Такое имя уже существует");
                }
            }
            
            if (company.FoundationDate > DateTime.Now)
            {
                ModelState.AddModelError("FoundationDay", "Компания не может быть основана в будущем");
            }
            
            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }
        
        // GET: Phones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Phones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,FoundationDay")] Company company)
        {
            if (id != company.Id)
            {
                return NotFound();
            }
            
            List<Company> companies = _context.Companies.ToList();

            foreach (Company company1 in companies)
            {
                if (company.Name == company1.Name)
                {
                    ModelState.AddModelError("Name", "Такое имя ужесуществует");
                }
            }
            
            if (company.FoundationDate > DateTime.Now)
            {
                ModelState.AddModelError("FoundationDay", "Компания не может быть основана в будущем");
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!companyExist(company.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        
        private bool companyExist(int companyId)
        {
            return _context.Companies.Any(e => e.Id == companyId);
        }
    }
}