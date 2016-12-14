using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DevEnvExamProject.Models
{
    public class EmployeeSkill
    {
        public int EmployeeSkillId { get; set; }
        public int EmployeeId { get; set; } //foreign key
        //public List<Skill> { get; set; } put somewhere else
    }
}