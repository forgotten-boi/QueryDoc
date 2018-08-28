using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    public class GetProgramListInput : EntityDto
    {
        public int UserTypeId { get; set; }
        public int ProgramTypeId { get; set; }
    }
}
