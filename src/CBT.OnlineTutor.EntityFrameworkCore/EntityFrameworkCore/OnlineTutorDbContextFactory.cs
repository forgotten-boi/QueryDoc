using CBT.OnlineTutor.Configuration;
using CBT.OnlineTutor.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace CBT.OnlineTutor.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class OnlineTutorDbContextFactory : IDbContextFactory<OnlineTutorDbContext>
    {
        public OnlineTutorDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<OnlineTutorDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder, 
                configuration.GetConnectionString(OnlineTutorConsts.ConnectionStringName)
                );

            return new OnlineTutorDbContext(builder.Options);
        }
    }
}