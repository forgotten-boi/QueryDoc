using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    public class GetCategoryListInput : EntityDto
    {
        public int? ParentId { get; set; }
        public int ProgramListId { get; set; }
    }
}
