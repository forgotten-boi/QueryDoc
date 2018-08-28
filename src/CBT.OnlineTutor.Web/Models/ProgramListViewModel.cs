using CBT.OnlineTutor.EClass.Dtos;
using System.Collections.Generic;

namespace CBT.OnlineTutor.Web.Models
{
    public class ProgramListViewModel
    {
        public IReadOnlyList<ProgramListDto> ProgramLists { get; }

        public ProgramListViewModel(IReadOnlyList<ProgramListDto> pList)
        {
            ProgramLists = pList;
        }

        public string GetTaskLabel(ProgramListDto pList)
        {
            switch (pList.Status)
            {
                case "NEW":
                    return "Indigo";
                case "UPDATED":
                    return "Indigo";
                case "ONGOING":
                    return "Cyan";
                case "POSTPONED":
                    return "Gray";
                case "CANCELED":
                    return "Red";
                case "COMPLETED":
                    return "Green";
                default:
                    return "Gray";
            }
        }
    }
}
