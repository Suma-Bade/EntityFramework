using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDAL.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Project",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Project",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Project",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Project",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);
        }
    }
}
