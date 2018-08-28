using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoryInput : EntityDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int ProgramListId { get; set; }
        public int CategoryOrder { get; set; }
    }
}
