using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBT.OnlineTutor.Migrations
{
    public partial class Initail_45821 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentId",
                table: "CBTContentOption");

            migrationBuilder.AlterColumn<int>(
                name: "CBTContentId",
                table: "CBTContentOption",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentId",
                table: "CBTContentOption",
                column: "CBTContentId",
                principalTable: "CBTContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentId",
                table: "CBTContentOption");

            migrationBuilder.AlterColumn<int>(
                name: "CBTContentId",
                table: "CBTContentOption",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentId",
                table: "CBTContentOption",
                column: "CBTContentId",
                principalTable: "CBTContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
