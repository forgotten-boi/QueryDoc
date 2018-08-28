using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapTo(typeof(CBTContentOptions))]
    public class UpdateCBTContentOptionsInput : EntityDto
    {
        public int CBTContentOptionId { get; set; }
        public string OptionValue { get; set; }
        public string DataType { get; set; }
    }
}
