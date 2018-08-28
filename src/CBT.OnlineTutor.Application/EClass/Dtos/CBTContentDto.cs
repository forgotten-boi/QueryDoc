using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapFrom(typeof(CBTContent))]
    public class CBTContentDto : EntityDto
    {
        public int CBTContentId { get; set; }
        public int? PrecedingCBTContentId { get; set; }
        public string PrecedingCBTContentCode { get; set; }
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
        public List<CBTContentOptionsDto> CBTContentOption { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }
    }
}
