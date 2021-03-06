using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationTechnologyCollege.Models
{
    public class Module
    {
        public virtual int ModuleID { get; set; }
        public virtual string ModuleCode { get; set; }
        public virtual string ModulTitle { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleContents { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}