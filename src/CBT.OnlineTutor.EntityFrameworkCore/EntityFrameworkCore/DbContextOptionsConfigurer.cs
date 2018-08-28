using Microsoft.EntityFrameworkCore;

namespace CBT.OnlineTutor.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<OnlineTutorDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for OnlineTutorDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
