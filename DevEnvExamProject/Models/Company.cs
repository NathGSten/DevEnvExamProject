﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DevEnvExamProject.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}