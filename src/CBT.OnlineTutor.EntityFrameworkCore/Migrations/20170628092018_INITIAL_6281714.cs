using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBT.OnlineTutor.Migrations
{
    public partial class INITIAL_6281714 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CBTContentOptions_CBTContent_CBTContentId",
                table: "CBTContentOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CBTContentOptions",
                table: "CBTContentOptions");

            migrationBuilder.RenameTable(
                name: "CBTContentOptions",
                newName: "CBTContentOption");

            migrationBuilder.RenameIndex(
                name: "IX_CBTContentOptions_CBTContentId",
                table: "CBTContentOption",
                newName: "IX_CBTContentOption_CBTContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CBTContentOption",
                table: "CBTContentOption",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CBTContentOption",
                table: "CBTContentOption");

            migrationBuilder.RenameTable(
                name: "CBTContentOption",
                newName: "CBTContentOptions");

            migrationBuilder.RenameIndex(
                name: "IX_CBTContentOption_CBTContentId",
                table: "CBTContentOptions",
                newName: "IX_CBTContentOptions_CBTContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CBTContentOptions",
                table: "CBTContentOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CBTContentOptions_CBTContent_CBTContentId",
                table: "CBTContentOptions",
                column: "CBTContentId",
                principalTable: "CBTContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
