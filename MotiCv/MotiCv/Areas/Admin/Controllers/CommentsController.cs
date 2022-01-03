using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entities;

namespace MotiCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentsController : Controller
    {
        private readonly MotiCvDbContext _context;

        public CommentsController(MotiCvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Comments
        [Authorize(Roles = "Superadmin")]
        public async Task<IActionResult> Index(int typeid)
        {
            var query = _context.Comments.AsQueryable();
            switch (typeid)
            {
                case 1:
                    query = query.Where(c=>c.AnsweredByUserId!=null);
                    return View(query);
                    break;
                case 2:
                    query = query.Where(c=>c.AnsweredByUserId!=null);
                    return View(query);
                    break;
            }
            var comments = await _context.Comments.ToListAsync();
            return View(comments);
        }

        // GET: Admin/Comments/Details/5
        [Authorize(Roles = "Superadmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Admin/Comments/Create


        // POST: Admin/Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        // GET: Admin/Comments/Edit/5


        // POST: Admin/Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Policy = "Admin.Comments.Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Admin/Comments/Delete/5
        [Authorize(Policy = "Admin.Comments.DeleteConfirmed")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
