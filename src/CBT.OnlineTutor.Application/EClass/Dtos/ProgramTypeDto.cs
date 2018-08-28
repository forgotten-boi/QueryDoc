using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapFrom(typeof(ProgramType))]
    public class ProgramTypeDto : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
