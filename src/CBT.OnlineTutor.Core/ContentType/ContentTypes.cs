using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace CBT.OnlineTutor.ContentType
{
    public class ContentTypes : AuditedEntity
    {
        public string ContentName { get; set; }
        public string Description { get; set; }
    }
}
