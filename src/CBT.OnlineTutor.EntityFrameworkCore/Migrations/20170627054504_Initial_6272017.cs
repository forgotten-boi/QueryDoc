using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBT.OnlineTutor.Migrations
{
    public partial class Initial_6272017 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "ProgramList");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "ProgramList",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UniqueId",
                table: "ProgramList",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "ProgramList",
                nullable: true);
        }
    }
}
