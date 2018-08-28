using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBT.OnlineTutor.Migrations
{
    public partial class Initial_6302017 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentId",
                table: "CBTContentOption");

            migrationBuilder.RenameColumn(
                name: "CBTContentId",
                table: "CBTContentOption",
                newName: "CBTContentsId");

            migrationBuilder.RenameIndex(
                name: "IX_CBTContentOption_CBTContentId",
                table: "CBTContentOption",
                newName: "IX_CBTContentOption_CBTContentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentsId",
                table: "CBTContentOption",
                column: "CBTContentsId",
                principalTable: "CBTContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentsId",
                table: "CBTContentOption");

            migrationBuilder.RenameColumn(
                name: "CBTContentsId",
                table: "CBTContentOption",
                newName: "CBTContentId");

            migrationBuilder.RenameIndex(
                name: "IX_CBTContentOption_CBTContentsId",
                table: "CBTContentOption",
                newName: "IX_CBTContentOption_CBTContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CBTContentOption_CBTContent_CBTContentId",
                table: "CBTContentOption",
                column: "CBTContentId",
                principalTable: "CBTContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
