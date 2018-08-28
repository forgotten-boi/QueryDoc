using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto : EntityDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public string ParentCategoryName { get; set; }
        public int ProgramListId { get; set; }
        public string ProgramCode { get; set; }
        public int CategoryOrder { get; set; }
        public List<CBTContentDto> CBTContents { get; set; }
    }
}
