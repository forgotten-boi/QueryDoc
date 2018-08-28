using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    public class GetProgramListOutput : EntityDto
    {
        public List<ProgramListDto> ProgramLists { get; set; }
    }
}
