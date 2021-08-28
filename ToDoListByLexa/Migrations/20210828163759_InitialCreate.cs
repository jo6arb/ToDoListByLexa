using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListByLexa.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DateAddGoal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateSuccessGoal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateConrtolGoal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Priority = table.Column<byte>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");
        }
    }
}
