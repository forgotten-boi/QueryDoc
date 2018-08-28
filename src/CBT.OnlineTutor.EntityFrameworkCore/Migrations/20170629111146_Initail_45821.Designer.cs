using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CBT.OnlineTutor.EntityFrameworkCore;

namespace CBT.OnlineTutor.Migrations
{
    [DbContext(typeof(OnlineTutorDbContext))]
    [Migration("20170629111146_Initail_45821")]
    partial class Initail_45821
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CBT.OnlineTutor.ContentType.ContentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentName");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.HasKey("Id");

                    b.ToTable("ContentType");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<int>("CategoryOrder");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<int?>("ParentId");

                    b.Property<int>("ProgramListId");

                    b.HasKey("Id");

                    b.HasIndex("ProgramListId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.CBTContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowMultipleChoice");

                    b.Property<int>("CBTContentOrder");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code");

                    b.Property<string>("Comment");

                    b.Property<int>("ContentTypeId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<bool>("IncludeComment");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<bool>("OnlyNumericValue");

                    b.Property<int?>("PrecedingCBTContentId");

                    b.Property<bool>("Required");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ContentTypeId");

                    b.ToTable("CBTContent");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.CBTContentOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CBTContentId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("DataType");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("OptionValue");

                    b.HasKey("Id");

                    b.HasIndex("CBTContentId");

                    b.ToTable("CBTContentOption");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.ProgramList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<string>("Feedback");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.Property<int>("ProgramCount");

                    b.Property<DateTime>("ProgramLastDate");

                    b.Property<int>("ProgramTypeId");

                    b.Property<string>("Status");

                    b.Property<string>("UniqueId");

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ProgramTypeId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("ProgramList");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.ProgramType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProgramType");
                });

            modelBuilder.Entity("CBT.OnlineTutor.Role.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CBT.OnlineTutor.User.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

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

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

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

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.Category", b =>
                {
                    b.HasOne("CBT.OnlineTutor.EClass.ProgramList", "PList")
                        .WithMany()
                        .HasForeignKey("ProgramListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.CBTContent", b =>
                {
                    b.HasOne("CBT.OnlineTutor.EClass.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CBT.OnlineTutor.ContentType.ContentTypes", "ContentType")
                        .WithMany()
                        .HasForeignKey("ContentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.CBTContentOptions", b =>
                {
                    b.HasOne("CBT.OnlineTutor.EClass.CBTContent")
                        .WithMany("CBTContentOption")
                        .HasForeignKey("CBTContentId");
                });

            modelBuilder.Entity("CBT.OnlineTutor.EClass.ProgramList", b =>
                {
                    b.HasOne("CBT.OnlineTutor.EClass.ProgramType", "PType")
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
