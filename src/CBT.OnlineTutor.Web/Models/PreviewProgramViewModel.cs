using CBT.OnlineTutor.EClass;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.Web.Models
{
    public class PreviewProgramViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public ProgramList PList { get; set; }
        public int ProgramListId { get; set; }
        public int CategoryOrder { get; set; }
        public virtual List<CBTContent> CBTContents { get; set; }
    }
}
