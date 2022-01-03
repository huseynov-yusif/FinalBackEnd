using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entitys;

namespace MotiCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyController : Controller
    {
        private readonly MotiCvDbContext _context;

        public MyController(MotiCvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/My
      
        public async Task<IActionResult> Index()
        {
            return View(await _context.MyData.ToListAsync());
        }

        // GET: Admin/My/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var my = await _context.MyData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (my == null)
            {
                return NotFound();
            }

            return View(my);
        }

        // GET: Admin/My/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/My/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Degree,Age,Location,Experience,CareerLevel,Phone,Fax,Email,website,Work,Id,CreatedDate,DeletedDate,CreatedByUserId,DeletedByUserId")] My my)
        {
            if (ModelState.IsValid)
            {
                _context.Add(my);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(my);
        }

        // GET: Admin/My/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var my = await _context.MyData.FindAsync(id);
            if (my == null)
            {
                return NotFound();
            }
            return View(my);
        }

        // POST: Admin/My/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Degree,Age,Location,Experience,CareerLevel,Phone,Fax,Email,website,Work,Id,CreatedDate,DeletedDate,CreatedByUserId,DeletedByUserId")] My my)
        {
            if (id != my.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(my);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyExists(my.Id))
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
            return View(my);
        }

        // GET: Admin/My/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var my = await _context.MyData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (my == null)
            {
                return NotFound();
            }

            return View(my);
        }

        // POST: Admin/My/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var my = await _context.MyData.FindAsync(id);
            _context.MyData.Remove(my);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyExists(int id)
        {
            return _context.MyData.Any(e => e.Id == id);
        }
       
    }
}
