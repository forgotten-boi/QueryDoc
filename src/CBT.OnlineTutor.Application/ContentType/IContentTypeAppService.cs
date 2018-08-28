using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.ContentType
{
    public interface IContentTypeAppService : IApplicationService
    {
        //COMMON METHODS
        Task<ListResultDto<ComboboxItemDto>> GetContentTypeDDLItems();
    }
}
