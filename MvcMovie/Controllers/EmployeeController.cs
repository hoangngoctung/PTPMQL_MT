using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcMovie.Data;
using MvcMovie.Models.Entities;
namespace MVCMOVIE.Controllers;

    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context; 
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
            {
            var employeeList=await _context.Employee.ToListAsync();
            return View(employeeList);
            }   
        
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]

            public async Task<IActionResult> Create(Employee employee)
            {
                if (ModelState.IsValid);
                {
                    _context.Add(employee);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
        }
