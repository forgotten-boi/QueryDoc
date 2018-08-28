using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace CBT.OnlineTutor.EClass
{
    public class ProgramType : AuditedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
