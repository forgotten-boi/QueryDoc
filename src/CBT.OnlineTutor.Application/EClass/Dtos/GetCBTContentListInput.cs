using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    public class GetCBTContentListInput : EntityDto
    {
        public int PrecedingCBTContentId { get; set; }
        public int CategoryId { get; set; }
        public int ContentTypeId { get; set; }
    }
}
