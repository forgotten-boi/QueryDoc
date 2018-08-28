using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace CBT.OnlineTutor.User
{
    public class UserType : AuditedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
