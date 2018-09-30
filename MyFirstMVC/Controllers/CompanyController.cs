using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}