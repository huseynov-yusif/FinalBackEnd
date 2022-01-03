using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entities;

namespace MotiCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        readonly MotiCvDbContext db;
        readonly IHostEnvironment env;
        public BlogController(MotiCvDbContext db, IHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public async Task<IActionResult> Index()
        {
            var result = await db.Blogs.ToListAsync();
            return View(result);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await db.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Skills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MasterName,ImagePath,Feature,Description,LongDescription,WorkName,BestLongDescription,Id,CreatedDate,DeletedDate,CreatedByUserId,DeletedByUserId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                var extension = Path.GetExtension(blog.File.FileName);
                blog.ImagePath = $"{Guid.NewGuid()}{extension}";
                var physicalAddress = Path.Combine(env.ContentRootPath,
                    "wwwroot",
                    "uploads",
                    "images",
                    blog.ImagePath);

                using (var stream = new FileStream(physicalAddress, FileMode.Create, FileAccess.Write))
                {
                    await blog.File.CopyToAsync(stream);

                }
                db.Add(blog);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await db.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: Admin/Skills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MasterName,ImagePath,Feature,Description,LongDescription,WorkName,BestLongDescription,Id,CreatedDate,DeletedDate,CreatedByUserId,DeletedByUserId")] Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(blog);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Id))
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
            return View(blog);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await db.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Admin/Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await db.Blogs.FindAsync(id);
            db.Blogs.Remove(blog);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool BlogExists(int id)
        {
            return db.Skills.Any(e => e.Id == id);
        }
    }
}
