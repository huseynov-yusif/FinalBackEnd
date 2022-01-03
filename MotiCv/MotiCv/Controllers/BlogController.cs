using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entities;
using MotiCv.Models.ViewModels;

namespace MotiCv.Controllers
{
    public class BlogController : Controller
    {
        readonly MotiCvDbContext db;
        public BlogController(MotiCvDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index(int pageIndex=1,int PageSize=3)
        {
            var model = db.Blogs.Where(x => x.DeletedByUserId == null);
            var pagedview = new PagedViewModel<Blog>(model,pageIndex,PageSize);

            return View(pagedview);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ForBlogViewModel model = new ForBlogViewModel();
            model.Blogs = await db.Blogs.FirstOrDefaultAsync(x => x.DeletedByUserId == null && x.Id == id);
            model.Comments = await db.Comments.Where(c => c.DeletedByUserId == null && c.BlogId == id).ToListAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Details(ForBlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment();
                comment.BlogId = model.BlogId;
                comment.Name = model.Name;
                comment.Email = model.Email;
                comment.Website = model.Website;
                comment.Subject = model.Subject;
                comment.Massage = model.Massage;

                db.Comments.Add(comment);
                await db.SaveChangesAsync();
                return Json(new
                {
                    error = false,
                    massage = "Mesajiniz qeyde alindi"
                });
            }
            return Json(new
            {
                error=true,
                massage="Tekrar cehd edin"
            });
        }
    }
}
