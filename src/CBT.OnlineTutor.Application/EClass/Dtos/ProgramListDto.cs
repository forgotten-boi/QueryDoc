using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapFrom(typeof(ProgramList))]
    public class ProgramListDto : EntityDto
    {
        public int ProgramId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Logo { get; set; }
        public string Status { get; set; }
        public int ProgramCount { get; set; }
        public DateTime ProgramLastDate { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public int ProgramTypeId { get; set; }
        public string ProgramName { get; set; }
        public string Feedback { get; set; }
    }
}
