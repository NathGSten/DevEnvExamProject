using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DevEnvExamProject.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public int CompanyId { get; set; } //foreign key
        public virtual Company Company { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        //public List<Syllabus> SkillSyllabus { get; set; }
    }
}