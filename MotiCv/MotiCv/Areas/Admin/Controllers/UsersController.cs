using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.DbContexts;
using System.Linq;
using MotiCv.Models.Entities.Membership;
using MotiCv.AppCode.Extension;

namespace MotiCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        readonly MotiCvDbContext db;
        public UsersController(MotiCvDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var data = await db.Users.ToListAsync();
            return View(data);
        }
        public async Task<IActionResult> Details(int id)
        {
            var user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.Roles = await (from r in db.Roles
                                   join ur in db.UserRoles
                                   on new { RoleId = r.Id, UserId = user.Id } equals new{ur.RoleId, ur.UserId} into ljoin
                from lj in ljoin.DefaultIfEmpty()
                select Tuple.Create(r.Id,r.Name,lj!=null)).ToListAsync();
            ViewBag.Principals = (from p in Program.principals
                join uc in db.UserClaims on new {ClaimValue="1",ClaimType=p, UserId =user.Id} equals new {uc.ClaimValue, uc.ClaimType,uc.UserId}
                into lJoin from lj in lJoin.DefaultIfEmpty()
                                        select Tuple.Create(p, lj != null)).ToList();
            return View(user);
        }
        public async Task<IActionResult> SetRole(int userid,int roleid,bool selected)
        {
            var user = await db.Users.FirstOrDefaultAsync(u=>u.Id==userid);
            var role = await db.Roles.FirstOrDefaultAsync(r=>r.Id==roleid);
            if (user==null)
            {
                return Json(new
                {
                    error=true,
                    massage="Xetali sorgu"
                });
            }
            if (role == null)
            {
                return Json(new
                {
                    error = true,
                    massage = "Xetali sorgu"
                });
            }
            if (selected)
            {
                if (await db.UserRoles.AnyAsync(ur=>ur.UserId==userid && ur.RoleId==roleid))
                {
                    return Json(new {
                        error = true,
                        massage =$"'{user.Name}{user.Surname}' adli istifadeci'{role.Name}' adli roldadir"
                    });
                }
                else
                {
                    db.UserRoles.Add(new MotiUserRole
                    {
                        UserId = userid,
                        RoleId=roleid
                    });
                    await db.SaveChangesAsync();
                    return Json(new
                    {
                        error = false,
                        massage = $"'{user.Name}{user.Surname}' adli istifadeci'{role.Name}' adli role elave edildi"
                    });
                }

            }
            else
            {
                var userrole = await db.UserRoles.FirstOrDefaultAsync(ur=> ur.UserId == userid && ur.RoleId==roleid);
                if (userrole==null)
                {
                    return Json(new
                    {
                        error=true,
                        massage=$"'{user.Name}{user.Surname}' adli isdifaci'{role.Name}' adli rolda deyil"
                    });
                }
                else
                {
                    db.UserRoles.Remove(userrole);
                    await db.SaveChangesAsync();
                    return Json(new
                    {
                        error = false,
                        massage = $"'{user.Name}{user.Surname}' adli isdifaci'{role.Name}' adli roldan cixarildi"
                    });
                }
            }
        }
        public async Task<IActionResult> SetPrincipal(int userId, string principalName, bool selected)
        {
            var user = await db.Users.FirstOrDefaultAsync(c => c.Id == userId);
            var hasPrincipal = Program.principals.Contains(principalName);
            if (user == null || !hasPrincipal)
            {
                return Json(new
                {
                    message = "Wrong query!",
                    error = true
                });
            }

           

            if (selected)
            {
                if (await db.UserClaims.AnyAsync(c => c.UserId == userId && c.ClaimType.Equals(principalName) && c.ClaimValue.Equals("1")))
                {
                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci artiq '{principalName}' adli selahiyyete malikdir.",
                        error = true
                    });
                }
                else
                {
                    db.UserClaims.Add(new MotiUserClaim
                    {
                        UserId = userId,
                        ClaimType = principalName,
                        ClaimValue = "1"

                    });

                    await db.SaveChangesAsync();

                    return Json(new
                    {
                        message = $"'{principalName}' adli selahiyyet '{user.UserName}' adli istifadeciye elave edildi.",
                        error = false
                    });
                }
            }
            else
            {
                var userClaim = await db.UserClaims.FirstOrDefaultAsync(c => c.UserId == userId && c.ClaimType.Equals(principalName) && c.ClaimValue.Equals("1"));
                if (userClaim == null)
                {
                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci '{principalName}' adli selahiyyete malik deyil.",
                        error = true
                    });
                }
                else
                {
                    db.UserClaims.Remove(userClaim);

                    await db.SaveChangesAsync();

                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci '{principalName}' adli selahiyyetden cixarildi.",
                        error = false
                    });
                }
            }
        }
    }
}
