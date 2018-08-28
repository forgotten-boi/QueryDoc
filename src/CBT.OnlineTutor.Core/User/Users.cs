using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CBT.OnlineTutor.User
{
    public class Users : AuditedEntity
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int PwdChangeDays { get; set; }
        public int PwdChangeWarningDays { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
