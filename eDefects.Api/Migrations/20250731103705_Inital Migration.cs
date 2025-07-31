using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDefects.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFound = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoundBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProdLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PUGroupID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProdUnitID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DefectLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DefectComponentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriorityID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FindSourceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CM1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CM2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CM3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defects");
        }
    }
}
