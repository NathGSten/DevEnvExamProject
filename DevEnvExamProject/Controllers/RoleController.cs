using DevEnvExamProject.Controllers;
using DevEnvExamProject.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace DevEnvExamProject.Controllers
{
    public class RoleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        ApplicationDbContext context;
        public void SkillController()
        {
            context = new ApplicationDbContext();
        }
        
        // GET: Role
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            var Roles = db.Roles.ToList();

            return View(Roles);
        }

        //[Authorize(Roles = "Admin")]
        //public ActionResult ListOfRoles()
        //{
        //    var currentUser = UserManager.FindById(User.Identity.GetUserId());
        //    var companyUsers = db.Users.Where(i => i.CompanyId == currentUser.CompanyId).ToList();

        //    return View(companyUsers);
        //}

        // GET: /Account/Register
        [Authorize(Roles = "Admin")]
        public ActionResult AddRole()
        {
            return View();
        }

        // POST: /Account/Register
        //[HttpPost]
        //[Authorize(Roles = "Admin")]
        //public ActionResult AddRole(RoleViewModel model, RegisterViewModel model)
        //{
        //    return View();
        //}

        [Authorize(Roles = "Admin")]
        public ActionResult ListOfRoles( )
        {
            //    var Skill = new Skill { SkillName = model.RoleName, SkillDescription = model.RoleDescription };
            //    var currentUser = UserManager.FindById(User.Identity.GetUserId());
            //    var companyUsers = db.Users.Where(i => i.CompanyId == currentUser.CompanyId).ToList();

            //    return View(companyUsers);
            return View();


        }



        // POST: /Account/Register
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> AddRole(RoleViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
        //        // var Skill = new Skill { SkillName = model.RoleName, SkillDescription = model.RoleDescription };
        //        var currentUser = UserManager.FindById(User.Identity.GetUserId());
        //        var skill = new Skill { SkillName = model.RoleName, SkillDescription = model.RoleDescription, CompanyId = currentUser };
        //        var result = await UserManager.CreateAsync(skill);

        //        var currentUser = UserManager.FindById(User.Identity.GetUserId());
        //        var companyUsers = db.Users.Where(i => i.CompanyId == currentUser.CompanyId).ToList();

        //        UserManager.AddToRole(user.Id, "Admin");
        //        if (result.Succeeded)
        //        {
        //            await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
        //            return RedirectToAction("Index", "Home"); //come back to this l8r
        //        }
        //        //ViewBag.Name = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin")).ToList(), "Name", "Name");
        //        AddErrors(result);
        //    }
        //    // If we got this far, something failed, redisplay form
        //return View(model);
        //}
    }
}