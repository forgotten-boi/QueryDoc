using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CBT.OnlineTutor.EntityFrameworkCore;

namespace CBT.OnlineTutor.Migrations
{
    [DbContext(typeof(OnlineTutorDbContext))]
    [Migration("20170622100648_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CBT.OnlineTutor.Role.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.Property<int?>("UsersId");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CBT.OnlineTutor.User.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("Password");

                    b.Property<int>("PwdChangeDays");

                    b.Property<int>("PwdChangeWarningDays");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Role.Roles", b =>
                {
                    b.HasOne("CBT.OnlineTutor.User.Users")
                        .WithMany("Roles")
                        .HasForeignKey("UsersId");
                });
        }
    }
}
