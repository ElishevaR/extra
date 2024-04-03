using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mng.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoleAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleForEmployee_Employee_EmployeeId",
                table: "RoleForEmployee");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "RoleForEmployee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "RoleForEmployee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleForEmployee_RoleId",
                table: "RoleForEmployee",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleForEmployee_Employee_EmployeeId",
                table: "RoleForEmployee",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleForEmployee_Role_RoleId",
                table: "RoleForEmployee",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleForEmployee_Employee_EmployeeId",
                table: "RoleForEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleForEmployee_Role_RoleId",
                table: "RoleForEmployee");

            migrationBuilder.DropIndex(
                name: "IX_RoleForEmployee_RoleId",
                table: "RoleForEmployee");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "RoleForEmployee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "RoleForEmployee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleForEmployee_Employee_EmployeeId",
                table: "RoleForEmployee",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
