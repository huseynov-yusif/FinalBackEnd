using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entities;

namespace MotiCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LocationController : Controller
    {
        private readonly MotiCvDbContext _context;

        public LocationController(MotiCvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Location
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocationContacts.ToListAsync());
        }

        // GET: Admin/Location/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationContact = await _context.LocationContacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationContact == null)
            {
                return NotFound();
            }

            return View(locationContact);
        }

        // GET: Admin/Location/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Location/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IconPath,Description,Id,CreatedDate,DeletedDate,CreatedByUserId,DeletedByUserId")] LocationContact locationContact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locationContact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationContact);
        }

        // GET: Admin/Location/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationContact = await _context.LocationContacts.FindAsync(id);
            if (locationContact == null)
            {
                return NotFound();
            }
            return View(locationContact);
        }

        // POST: Admin/Location/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IconPath,Description,Id,CreatedDate,DeletedDate,CreatedByUserId,DeletedByUserId")] LocationContact locationContact)
        {
            if (id != locationContact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationContactExists(locationContact.Id))
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
            return View(locationContact);
        }

        // GET: Admin/Location/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationContact = await _context.LocationContacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationContact == null)
            {
                return NotFound();
            }

            return View(locationContact);
        }

        // POST: Admin/Location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationContact = await _context.LocationContacts.FindAsync(id);
            _context.LocationContacts.Remove(locationContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationContactExists(int id)
        {
            return _context.LocationContacts.Any(e => e.Id == id);
        }
    }
}
