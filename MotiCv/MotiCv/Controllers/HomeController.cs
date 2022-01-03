using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MotiCv.AppCode.Extension;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entities;
using MotiCv.Models.Entities.Membership;
using MotiCv.Models.Entitys;
using MotiCv.Models.FormModels;
using MotiCv.Models.ViewModels;
using MotiCv.Models.WievBoxModel;

namespace MotiCv.Controllers
{
    public class HomeController : Controller
    {
        readonly MotiCvDbContext db;
        readonly SignInManager<MotiUser> signinmanager;
        readonly UserManager<MotiUser> usermanager;
        public HomeController(MotiCvDbContext db,SignInManager<MotiUser> signinmanager,UserManager<MotiUser> usermanager)
        {
            this.db = db;
            this.signinmanager = signinmanager;
            this.usermanager = usermanager;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var wiewmodel = new HomeWievModel();
            wiewmodel.Mys = await db.MyData.Where(c => c.DeletedByUserId == null).ToListAsync();
            wiewmodel.Services = await db.Services.Where(c => c.DeletedByUserId == null).ToListAsync();
            wiewmodel.Skills = await db.Skills.Where(c => c.DeletedByUserId == null).ToListAsync();


            return View(wiewmodel);
        }

        [AllowAnonymous]
        public IActionResult SignIn()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginUserModel user)
        {
            if (ModelState.IsValid)
            {
                MotiUser foundeduser = null;
                if (user.UserName.IsMail())
                {
                    foundeduser = await usermanager.FindByEmailAsync(user.UserName);
                }
                else
                {
                    foundeduser = await usermanager.FindByNameAsync(user.UserName);
                }
                if (foundeduser == null)
                {

                    ViewBag.Massage = ("Istifadeci adi ve ya sifreniz yalnisdir");
                    goto end;
                }
                var signnresult = await signinmanager.PasswordSignInAsync(foundeduser, user.Password, true, true);
                if (!signnresult.Succeeded)
                {
                    ViewBag.Massage = ("Istifadeci di ve ya sifreniz yalnisdir");
                    goto end;
                }

                var callbackurl = Request.Query["ReturnUrl"];
                if (!string.IsNullOrWhiteSpace(callbackurl))
                {
                    return RedirectToPage(callbackurl);  
                }
                else
                {
                    return RedirectToAction("SignIn", "Home");
                }
            }
            end:
            return View(user);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]

        public async Task<IActionResult> Register(RegisterUserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new MotiUser();
                user.Email = model.Email;
                user.UserName = model.Email;
                user.Name = model.Name;
                user.SurName = model.SurName;
                user.EmailConfirmed = true;
                var result = await usermanager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    ViewBag.Massage = "Qeydiyyat tamamlandi";
                    return RedirectToAction(nameof(SignIn));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var location = new ContactPostViewModel();
            location.LocationContacts= db.LocationContacts.Where(c => c.DeletedByUserId == null).ToList();
            return View(location);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact( ContactPostViewModel model)
        {
            if (ModelState.IsValid)
            {
                ContactPost contactPost = new ContactPost();
                contactPost.Name = model.Name;
                contactPost.Email = model.Email;
                contactPost.Content = model.Content;
                contactPost.Subject = model.Subject;
                db.ContactPosts.Add(contactPost);
                db.SaveChanges();
                return Json(new
                {
                    error = false,
                    massage ="Mesajiniz qeyde alindi"
                });
            }
            return Json(new
            {
                error=true,
                massage="Tekrar cehd edin"
            });

       
            
        }
        [Route("/accesdenied.html")]
        [AllowAnonymous]
        public IActionResult AccessDeny()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await signinmanager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}
