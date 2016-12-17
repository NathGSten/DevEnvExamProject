using DevEnvExamProject.Controllers;
using DevEnvExamProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DevEnvExamProject.Controllers
{
    public class UsersController : Controller
    {
        public object UserName { get; set; }
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;
        ApplicationDbContext context;
        public void AccountController()
        {
            context = new ApplicationDbContext();
        }
        public void AccountController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        // GET: Users
        [Authorize]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;
                ViewBag.displayMenu = "No";
                if (User.IsInRole("Admin"))
                {
                    ViewBag.displayMenu = "Yes";
                }
                return View();
            }
            else
            {
                ViewBag.Name = "Not logged in";
            }
            return View();
        }

        public ActionResult ListOfEmployees()
        {
            var currentUser = UserManager.FindById(User.Identity.GetUserId());

            var companyUsers = db.Users.Where(i => i.CompanyId == currentUser.CompanyId).ToList();

            return View(companyUsers);
        }
    }
}