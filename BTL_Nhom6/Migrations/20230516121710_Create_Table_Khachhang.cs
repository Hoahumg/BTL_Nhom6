﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTL_Nhom6.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Khachhang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khachhang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "TEXT", nullable: false),
                    TenKH = table.Column<string>(type: "TEXT", nullable: true),
                    NgaysinhKH = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiachiKH = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.MaKH);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Khachhang");
        }
    }
}
