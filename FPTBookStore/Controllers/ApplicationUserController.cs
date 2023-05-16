using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPTBookStore.Data;
using FPTBookStore.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Identity;

namespace FPTBookStore.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ApplicationRole
        public async Task<IActionResult> Index()
        {
            return _context.ApplicationUsers != null ?
                        View(await _context.ApplicationUsers.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.ApplicationUsers'  is null.");
        }

        // GET: ApplicationRole/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.ApplicationUsers == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.ApplicationUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // GET: ApplicationRole/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.ApplicationUsers == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.ApplicationUsers.FindAsync(id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            List<IdentityRole> applicationRole = await _context.Roles.ToListAsync();
            return View(new UserRoleViewModel(applicationUser, applicationRole));
        }

        // POST: ApplicationRole/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Email,Name,PhoneNumber,Roles")] ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //applicationUser.Roles = Request["applicationUser_Roles"];
                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(applicationUser.Id))
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
            List<IdentityRole> applicationRole = await _context.Roles.ToListAsync();
            return View(new UserRoleViewModel(applicationUser, applicationRole));
        }

        private bool ApplicationUserExists(string id)
        {
            return (_context.ApplicationUsers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
