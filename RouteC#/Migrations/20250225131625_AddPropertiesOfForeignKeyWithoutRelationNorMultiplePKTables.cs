using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RouteC_.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertiesOfForeignKeyWithoutRelationNorMultiplePKTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dep_Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dept_Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ins_Id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Top_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Dept_Id",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Ins_Id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Top_Id",
                table: "Courses");
        }
    }
}
