using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CBT.OnlineTutor.Migrations
{
    public partial class Initial_06262016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditInfo");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "UserType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "UserType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "UserType",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "UserType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "UserRole",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "UserRole",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "UserRole",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "UserRole",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Role",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Role",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Role",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Role",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "ContentType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "ContentType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "ContentType",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "ContentType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "ProgramType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "ProgramType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "ProgramType",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "ProgramType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "ProgramList",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "ProgramList",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "ProgramList",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "ProgramList",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "CBTProgram",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "CBTProgram",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "CBTProgram",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "CBTProgram",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "UserType");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "UserType");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "UserType");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "UserType");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "ContentType");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "ContentType");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "ContentType");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "ContentType");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "ProgramType");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "ProgramType");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "ProgramType");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "ProgramType");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "ProgramList");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "ProgramList");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "ProgramList");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "ProgramList");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "CBTProgram");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "CBTProgram");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "CBTProgram");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "CBTProgram");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Category");

            migrationBuilder.CreateTable(
                name: "AuditInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditInfo", x => x.Id);
                });
        }
    }
}
