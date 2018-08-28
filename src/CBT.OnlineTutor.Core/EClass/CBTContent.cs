using Abp.Domain.Entities.Auditing;
using CBT.OnlineTutor.ContentType;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBT.OnlineTutor.EClass
{
    public class CBTContent : AuditedEntity
    {
        public int? PrecedingCBTContentId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public bool OnlyNumericValue { get; set; }
        public bool IncludeComment { get; set; }
        public string Comment { get; set; }
        public bool AllowMultipleChoice { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Categories { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(ContentTypeId))]
        public ContentTypes ContentType { get; set; }
        public int ContentTypeId { get; set; }
        public int CBTContentOrder { get; set; }
        public virtual ICollection<CBTContentOptions> CBTContentOption { get; set; }
        public string FileName { get; set; }
        public string Location { get; set; }
    }
}
