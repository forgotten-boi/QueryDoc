using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.Web.Models
{
    public class CreateProgramViewModel
    {
        public List<SelectListItem> UserType { get; set; }
        public List<SelectListItem> ProgramType { get; set; }

        public CreateProgramViewModel(List<SelectListItem> uType, List<SelectListItem> pType)
        {
            UserType = uType;
            ProgramType = pType;
        }

        public int ProgramId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        //public int ProgramCount { get; set; }
        public DateTime ProgramLastDate { get; set; }
        public int UserTypeId { get; set; }
        public int ProgramTypeId { get; set; }
        //public string Feedback { get; set; }
    }
}
