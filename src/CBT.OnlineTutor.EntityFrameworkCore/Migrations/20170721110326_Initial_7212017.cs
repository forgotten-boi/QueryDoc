using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBT.OnlineTutor.Migrations
{
    public partial class Initial_7212017 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "CBTContent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "CBTContent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "CBTContent");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "CBTContent");
        }
    }
}
