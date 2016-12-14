using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DevEnvExamProject.Models
{
    public class CompanyAdmin : ApplicationUser
    {
        public int CompanyId { get; set; }
        public bool IsAdmin = true; //y green squiggle
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyLogo { get; set; } //can refer to a common interface?
        //public List<Roles> { get; set; }
        //public List<object> CompanyExperience { get; set; }
    }
}