using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PremierLeague.Persistence.Migrations
{
  public partial class InitialMigration : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Teams",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
            Name = table.Column<string>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Teams", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "Games",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
            Round = table.Column<int>(nullable: false),
            HomeTeamId = table.Column<int>(nullable: false),
            GuestTeamId = table.Column<int>(nullable: false),
            HomeGoals = table.Column<int>(nullable: false),
            GuestGoals = table.Column<int>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Games", x => x.Id);
            table.ForeignKey(
                      name: "FK_Games_Teams_GuestTeamId",
                      column: x => x.GuestTeamId,
                      principalTable: "Teams",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.NoAction);
            table.ForeignKey(
                      name: "FK_Games_Teams_HomeTeamId",
                      column: x => x.HomeTeamId,
                      principalTable: "Teams",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.NoAction);
          });

      migrationBuilder.CreateIndex(
          name: "IX_Games_GuestTeamId",
          table: "Games",
          column: "GuestTeamId");

      migrationBuilder.CreateIndex(
          name: "IX_Games_HomeTeamId",
          table: "Games",
          column: "HomeTeamId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Games");

      migrationBuilder.DropTable(
          name: "Teams");
    }
  }
}
