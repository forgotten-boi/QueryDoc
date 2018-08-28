using CBT.OnlineTutor.EClass.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.Web.Models
{
    public class CategoryListViewModel
    {
        public IReadOnlyList<CategoryDto> CategoryLists { get; }
        public List<SelectListItem> ProgramList { get; set; }
        public CategoryListViewModel(IReadOnlyList<CategoryDto> cList)
        {
            CategoryLists = cList;
        }

        public IReadOnlyList<CBTContentDto> CBTContentLists { get; set; }
        public int ProgramListId { get; set; }
    }
}
