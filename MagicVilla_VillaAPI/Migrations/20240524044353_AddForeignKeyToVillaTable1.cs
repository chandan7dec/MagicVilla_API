using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillasNumbers_Villas_VillId",
                table: "VillasNumbers");

            migrationBuilder.RenameColumn(
                name: "VillId",
                table: "VillasNumbers",
                newName: "VillaId");

            migrationBuilder.RenameIndex(
                name: "IX_VillasNumbers_VillId",
                table: "VillasNumbers",
                newName: "IX_VillasNumbers_VillaId");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 13, 53, 420, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 13, 53, 420, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 13, 53, 420, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 13, 53, 420, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 13, 53, 420, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.AddForeignKey(
                name: "FK_VillasNumbers_Villas_VillaId",
                table: "VillasNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillasNumbers_Villas_VillaId",
                table: "VillasNumbers");

            migrationBuilder.RenameColumn(
                name: "VillaId",
                table: "VillasNumbers",
                newName: "VillId");

            migrationBuilder.RenameIndex(
                name: "IX_VillasNumbers_VillaId",
                table: "VillasNumbers",
                newName: "IX_VillasNumbers_VillId");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 9, 48, 52, 754, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 9, 48, 52, 754, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 9, 48, 52, 754, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 9, 48, 52, 754, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 9, 48, 52, 754, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.AddForeignKey(
                name: "FK_VillasNumbers_Villas_VillId",
                table: "VillasNumbers",
                column: "VillId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
