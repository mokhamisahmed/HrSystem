using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    public partial class y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        migrationBuilder.DropColumn(
       name: "CompanyInfoId",
       table: "LeaveBalances");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
