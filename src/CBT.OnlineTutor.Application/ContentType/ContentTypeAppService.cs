using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.ContentType
{
    public class ContentTypeAppService : OnlineTutorAppServiceBase, IContentTypeAppService
    {
        private readonly IRepository<ContentTypes> _contentTypeRepository;

        public ContentTypeAppService(IRepository<ContentTypes> contentTypeRepository)
        {
            _contentTypeRepository = contentTypeRepository;
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetContentTypeDDLItems()
        {
            var contentType = await _contentTypeRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                contentType.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.ContentName)).ToList()
            );
        }
    }
}
