using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class PKFKDeptSt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DId",
                table: "Students",
                column: "DId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DId",
                table: "Students",
                column: "DId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DId",
                table: "Students");
        }
    }
}
