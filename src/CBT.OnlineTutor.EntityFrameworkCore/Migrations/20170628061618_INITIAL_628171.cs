using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CBT.OnlineTutor.Migrations
{
    public partial class INITIAL_628171 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CBTProgram");

            migrationBuilder.CreateTable(
                name: "CBTContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowMultipleChoice = table.Column<bool>(nullable: false),
                    CBTContentOrder = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ContentTypeId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IncludeComment = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    OnlyNumericValue = table.Column<bool>(nullable: false),
                    PrecedingCBTContentId = table.Column<int>(nullable: false),
                    Required = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBTContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CBTContent_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CBTContent_ContentType_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CBTContent_CategoryId",
                table: "CBTContent",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CBTContent_ContentTypeId",
                table: "CBTContent",
                column: "ContentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CBTContent");

            migrationBuilder.CreateTable(
                name: "CBTProgram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowMultipleChoice = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ContentTypeId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IncludeComment = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    OnlyNumericValue = table.Column<bool>(nullable: false),
                    PrecedingCBTProgramId = table.Column<int>(nullable: false),
                    Required = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBTProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CBTProgram_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CBTProgram_ContentType_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CBTProgram_CategoryId",
                table: "CBTProgram",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CBTProgram_ContentTypeId",
                table: "CBTProgram",
                column: "ContentTypeId");
        }
    }
}
