using CBT.OnlineTutor.EClass.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.Web.Models
{
    public class CBTContentListViewModel
    {
        public IReadOnlyList<CBTContentDto> CBTContentLists { get; }

        public CBTContentListViewModel(IReadOnlyList<CBTContentDto> cbtList)
        {
            CBTContentLists = cbtList;
        }
    }
}
