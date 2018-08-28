using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using CBT.OnlineTutor.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBT.OnlineTutor.EClass
{
    public class ProgramList : AuditedEntity
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Logo { get; set; }
        public string Status { get; set; }
        public int ProgramCount { get; set; }
        public DateTime ProgramLastDate { get; set; }

        [ForeignKey(nameof(UserTypeId))]
        public UserType UType { get; set; }
        public int UserTypeId { get; set; }

        [ForeignKey(nameof(ProgramTypeId))]
        public ProgramType PType { get; set; }
        public int ProgramTypeId { get; set; }
        public string Feedback { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
