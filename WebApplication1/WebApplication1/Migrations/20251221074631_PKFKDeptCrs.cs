using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class PKFKDeptCrs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DId",
                table: "Courses",
                column: "DId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DId",
                table: "Courses",
                column: "DId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DId",
                table: "Courses");
        }
    }
}
