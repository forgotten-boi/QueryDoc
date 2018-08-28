using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapTo(typeof(CBTContent))]
    public class UpdateCBTContentInput : EntityDto
    {
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
        public int ContentTypeId { get; set; }
        public int CBTContentOrder { get; set; }
        public string[] CBTContentOption { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }

        //public List<UpdateCBTContentOptionsInput> CBTContentOption { get; set; }
    }
}
