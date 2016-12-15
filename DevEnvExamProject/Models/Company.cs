using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DevEnvExamProject.Models
{
    public class Company
    {

        
        // hello hello
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}