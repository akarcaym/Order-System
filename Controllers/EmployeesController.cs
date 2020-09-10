using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Models;
using Microsoft.AspNetCore.Authorization;

//signout fonk


namespace OrderManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly SysContext _context;

        public EmployeesController(SysContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create1()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,Name,LName,Password,JTitle")] Employee employee)
        {

            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Email,Name,LName,Password,JTitle")] Employee employee)
        {
            if (id != employee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.ID))
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
            return View(employee);
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = _context.Employees.First(k => k.ID == id);
            _context.Employees.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private bool EmployeeExists(string id)
        {
            return _context.Employees.Any(e => e.ID == id);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Employee emp)
        {

            var userLoggedIn = _context.Employees.Where(x => x.Email == emp.Email && x.Password == emp.Password).FirstOrDefault();
         
            if (userLoggedIn != null)
            {
                
                return RedirectToAction("HomeUser", "Home", new { area = "" });
            }
            else
            {
                
                return View("~/Views/Home/Index.cshtml");

            }
        }
    }
}
