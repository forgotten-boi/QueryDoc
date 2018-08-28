using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using CBT.OnlineTutor.Role;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBT.OnlineTutor.User
{
    public class UserRole : AuditedEntity
    {
        [ForeignKey(nameof(UserId))]
        public Users User { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Roles Role { get; set; }
        public int RoleId { get; set; }
    }
}
