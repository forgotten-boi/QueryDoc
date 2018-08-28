using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace CBT.OnlineTutor.Role
{
    public class Roles : AuditedEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
    
}
