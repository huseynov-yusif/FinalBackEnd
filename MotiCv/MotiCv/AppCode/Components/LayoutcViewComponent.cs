using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotiCv.Models.DbContexts;

namespace MotiCv.AppCode.Components
{
    public class LayoutcViewComponent:ViewComponent
    {
        readonly MotiCvDbContext context;
        public LayoutcViewComponent(MotiCvDbContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var display = context.MyData.Where(c=>c.DeletedByUserId == null).ToList();
            return View(display);
        }
    }
}
