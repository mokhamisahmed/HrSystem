using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    public partial class rr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    isAccept = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRegistrations_AspNetUsers_employeeId",
                        column: x => x.employeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaveRegistrations_types_typeId",
                        column: x => x.typeId,
                        principalTable: "types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRegistrations_employeeId",
                table: "LeaveRegistrations",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRegistrations_typeId",
                table: "LeaveRegistrations",
                column: "typeId");

            migrationBuilder.DropColumn(
       name: "companyInfoId",
       table: "LeaveBalances");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRegistrations");
        }
    }
}
