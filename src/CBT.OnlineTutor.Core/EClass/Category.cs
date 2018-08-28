using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBT.OnlineTutor.EClass
{
    public class Category : AuditedEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }

        [ForeignKey(nameof(ProgramListId))]
        public ProgramList PList { get; set; }
        public int ProgramListId { get; set; }
        public int CategoryOrder { get; set; }
        public virtual ICollection<CBTContent> CBTContents { get; set; }
    }
}
