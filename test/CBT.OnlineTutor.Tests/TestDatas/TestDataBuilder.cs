using CBT.OnlineTutor.EntityFrameworkCore;

namespace CBT.OnlineTutor.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly OnlineTutorDbContext _context;

        public TestDataBuilder(OnlineTutorDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}