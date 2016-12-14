using DevEnvExamProject.Controllers;
using DevEnvExamProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DevEnvExamProject.Controllers
{
    public class UsersController : Controller
    {
        public object UserName { get; private set; }

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
        //public bool isAdminUser()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var user = User.Identity;
        //        ApplicationDbContext context = new ApplicationDbContext();
        //        var UserManager = new UserManager<ApplicationUser>( new UserStore<ApplicationUser>(context) );
        //        var s = UserManager.GetRoles(user.GetUserId());
        //        if (s[0].ToString() == "Admin")
        //        {
        //            return true;
        //        } else
        //        {
        //            return false;
        //        }
        //        return false;
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string name = Profile.UserName;
                DateTime lastVisited = Profile.VisitedOn;
                if (name == string.Empty)
                {
                    //User has not specified his name
                    UserName.Text = "Guest";
                }
                else
                {
                    //returning user, show his name
                    UserName.Text = name;
                }
                if (lastVisited.ToString() == "1/1/0001 12:00:00 AM")
                {
                    Label2.Text = "Never";
                }
                else
                {
                    Label2.Text = lastVisited.ToString();
                }
            }
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            Profile.VisitedOn = DateTime.Now;
            Profile.Save();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Profile.UserName = TextBox1.Text;
            Profile.Save();
            Label1.Text = TextBox1.Text;
        }


    }
}