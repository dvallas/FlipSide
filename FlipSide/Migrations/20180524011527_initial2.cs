using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FlipSide.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
      name: "Story");
            migrationBuilder.CreateTable(
    name: "Story",
    columns: table => new
    {
        ID = table.Column<int>(nullable: false)
            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        byline = table.Column<string>(nullable: false),
        dateRan = table.Column<DateTime>(nullable: false),
        lean = table.Column<int>(nullable: false),
        slug = table.Column<string>(nullable: false),
        summary = table.Column<string>(nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Story", x => x.ID);
    });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
