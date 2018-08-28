using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.Web.Models
{
    public class CreateCategoryViewModel
    {
        public List<SelectListItem> CategoryList { get; set; }
        public List<SelectListItem> ProgramList { get; set; }

        public CreateCategoryViewModel(List<SelectListItem> cList, List<SelectListItem> pList)
        {
            CategoryList = cList;
            ProgramList = pList;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int ProgramListId { get; set; }
        public string ProgramName { get; set; }
        public int CategoryOrder { get; set; }
    }
}
