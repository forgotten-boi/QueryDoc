using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.ContentType.Dtos
{
    [AutoMapFrom(typeof(ContentTypes))]
    public class ContentTypeDto : EntityDto
    {
        public string ContentName { get; set; }
        public string Description { get; set; }
    }
}
