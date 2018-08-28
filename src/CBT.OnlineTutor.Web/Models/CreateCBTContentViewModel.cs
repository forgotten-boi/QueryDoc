using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CBT.OnlineTutor.Web.Models
{
    public class CreateCBTContentViewModel
    {
        public List<SelectListItem> CategoryList { get; set; }
        public List<SelectListItem> ContentTypeList { get; set; }
        public List<SelectListItem> CBTContentList { get; set; }

        public CreateCBTContentViewModel(List<SelectListItem> cList, List<SelectListItem> ctList, List<SelectListItem> cbtList)
        {
            CategoryList = cList;
            ContentTypeList = ctList;
            CBTContentList = cbtList;
        }

        public int CBTContentId { get; set; }
        public int? PrecedingCBTContentId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public bool OnlyNumericValue { get; set; }
        public bool IncludeComment { get; set; }
        public string Comment { get; set; }
        public bool AllowMultipleChoice { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ContentTypeId { get; set; }
        public string ContentName { get; set; }
        public int CBTContentOrder { get; set; }
        public List<CBTContentOptionViewModel> CBTContentOption { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }
    }
}
