using CBT.OnlineTutor.EClass.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.Web.Models
{
    public class CBTContentOptionListViewModel
    {
        public IReadOnlyList<CBTContentOptionsDto> CBTContentOptionLists { get; }

        public CBTContentOptionListViewModel(IReadOnlyList<CBTContentOptionsDto> cbtoList)
        {
            CBTContentOptionLists = cbtoList;
        }
    }
}
