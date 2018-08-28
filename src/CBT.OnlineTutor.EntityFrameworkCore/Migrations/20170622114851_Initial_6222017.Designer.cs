using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CBT.OnlineTutor.EntityFrameworkCore;

namespace CBT.OnlineTutor.Migrations
{
    [DbContext(typeof(OnlineTutorDbContext))]
    [Migration("20170622114851_Initial_6222017")]
    partial class Initial_6222017
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CBT.OnlineTutor.AuditInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.HasKey("Id");

                    b.ToTable("AuditInfo");
                });

            modelBuilder.Entity("CBT.OnlineTutor.ContentType.ContentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentName");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ContentType");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.Property<int>("ParentId");

                    b.Property<int>("ProgramListId");

                    b.HasKey("Id");

                    b.HasIndex("ProgramListId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.CBTProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowMultipleChoice");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code");

                    b.Property<string>("Comment");

                    b.Property<int>("ContentTypeId");

                    b.Property<string>("Description");

                    b.Property<bool>("IncludeComment");

                    b.Property<bool>("OnlyNumericValue");

                    b.Property<int>("PrecedingCBTProgramId");

                    b.Property<bool>("Required");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ContentTypeId");

                    b.ToTable("CBTProgram");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.ProgramList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Feedback");

                    b.Property<string>("Logo");

                    b.Property<string>("Name");

                    b.Property<int>("ProgramCount");

                    b.Property<DateTime>("ProgramLastDate");

                    b.Property<int>("ProgramTypeId");

                    b.Property<bool>("Status");

                    b.Property<int>("UniqueId");

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ProgramTypeId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("ProgramList");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.ProgramType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProgramType");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Role.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CBT.OnlineTutor.User.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
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

            modelBuilder.Entity("CBT.OnlineTutor.User.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.Category", b =>
                {
                    b.HasOne("CBT.OnlineTutor.Program.ProgramList", "PList")
                        .WithMany()
                        .HasForeignKey("ProgramListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.CBTProgram", b =>
                {
                    b.HasOne("CBT.OnlineTutor.Program.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CBT.OnlineTutor.ContentType.ContentTypes", "ContentType")
                        .WithMany()
                        .HasForeignKey("ContentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBT.OnlineTutor.Program.ProgramList", b =>
                {
                    b.HasOne("CBT.OnlineTutor.Program.ProgramType", "PType")
                        .WithMany()
                        .HasForeignKey("ProgramTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CBT.OnlineTutor.User.UserType", "UType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBT.OnlineTutor.User.UserRole", b =>
                {
                    b.HasOne("CBT.OnlineTutor.Role.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CBT.OnlineTutor.User.Users", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
