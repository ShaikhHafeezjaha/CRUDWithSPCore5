using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDSPWithCore5.Migrations
{
    public partial class add_GetAllStudentSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER PROCEDURE [dbo].[GetAllStudent]
                AS
                BEGIN
	                SELECT * FROM StudentMasters
                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
