using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entitys;
using MotiCv.Models.ViewModels;

namespace MotiCv.AppCode.Components
{
    public class LayoutContactViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            ContactPostForLayout model = new ContactPostForLayout();
            return View("LayoutContact",model);   
        }


    }
}
