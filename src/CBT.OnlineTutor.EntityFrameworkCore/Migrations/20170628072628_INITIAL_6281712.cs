using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBT.OnlineTutor.Migrations
{
    public partial class INITIAL_6281712 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrecedingCBTContentId",
                table: "CBTContent",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrecedingCBTContentId",
                table: "CBTContent",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
