using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBT.OnlineTutor.EClass
{
    public class CBTContentOptions : AuditedEntity
    {
        public string OptionValue { get; set; }
        public string DataType { get; set; }
        public CBTContent CBTContent { get; set; }
    }
}
