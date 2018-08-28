using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapTo(typeof(CBTContentOptions))]
    public class CreateCBTContentOptionsInput : EntityDto
    {
        public string OptionValue { get; set; }
        public string DataType { get; set; }
    }
}
