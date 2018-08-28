using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CBT.OnlineTutor.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor.EClass.Dtos
{
    [AutoMapFrom(typeof(UserType))]
    public class UserTypeDto : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
