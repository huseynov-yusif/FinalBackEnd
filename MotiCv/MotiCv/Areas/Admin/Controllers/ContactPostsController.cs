using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entitys;

namespace MotiCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactPostsController : Controller
    {
        private readonly MotiCvDbContext _context;

        public ContactPostsController(MotiCvDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int typeId)
        {
            var query = _context.ContactPosts.AsQueryable();
            switch (typeId)
            {
                case 1:
                    query = query.Where(cp => cp.AnsweredByUserId != null);
                    return View(query);
                    break;
                case 2:
                    query = query.Where(cp => cp.AnsweredByUserId == null);
                    return View(query);
                    break;
                case 3:
                    query = query.Where(cp => cp.DeletedByUserId != null);
                    return View(query);
                    break;
                default:
                    break;
            }

            var cp = await _context.ContactPosts.ToListAsync();
            return View(cp);
        }

        [Authorize(Roles = "Superadmin")]
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await _context.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }

       
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await _context.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }

        // POST: Admin/ContactPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactPost = await _context.ContactPosts.FindAsync(id);
            _context.ContactPosts.Remove(contactPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactPostExists(int id)
        {
            return _context.ContactPosts.Any(e => e.Id == id);
        }
    }
}
