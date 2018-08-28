using Abp.EntityFrameworkCore;
using CBT.OnlineTutor.ContentType;
using CBT.OnlineTutor.EClass;
using CBT.OnlineTutor.Role;
using CBT.OnlineTutor.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CBT.OnlineTutor.EntityFrameworkCore
{
    public class OnlineTutorDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Roles> Role { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<ContentTypes> ContentType { get; set; }
        public DbSet<ProgramType> ProgramType { get; set; }
        public DbSet<ProgramList> ProgramList { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CBTContent> CBTContent { get; set; }
        public DbSet<CBTContentOptions> CBTContentOption { get; set; }

        //public DbSet<AuditInfo> AuditInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CBTContentOptions>()
            .HasOne(p => p.CBTContent)
            .WithMany(b => b.CBTContentOption)
            .OnDelete(DeleteBehavior.Cascade);
        }

        public OnlineTutorDbContext(DbContextOptions<OnlineTutorDbContext> options) 
            : base(options)
        {

        }
    }
}
