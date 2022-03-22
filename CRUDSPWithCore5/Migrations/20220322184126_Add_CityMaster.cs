using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDSPWithCore5.Migrations
{
    public partial class Add_CityMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "StudentMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CityMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMasters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentMasters_CityId",
                table: "StudentMasters",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentMasters_CityMasters_CityId",
                table: "StudentMasters",
                column: "CityId",
                principalTable: "CityMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentMasters_CityMasters_CityId",
                table: "StudentMasters");

            migrationBuilder.DropTable(
                name: "CityMasters");

            migrationBuilder.DropIndex(
                name: "IX_StudentMasters_CityId",
                table: "StudentMasters");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "StudentMasters");
        }
    }
}
