﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDepartment.Migrations
{
    public partial class DeleteColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "departmens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "departmens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
