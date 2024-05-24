using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdtedDate",
                table: "VillasNumbers",
                newName: "UpdatedDate");

            migrationBuilder.AddColumn<int>(
                name: "VillId",
                table: "VillasNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_VillasNumbers_VillId",
                table: "VillasNumbers",
                column: "VillId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillasNumbers_Villas_VillId",
                table: "VillasNumbers",
                column: "VillId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillasNumbers_Villas_VillId",
                table: "VillasNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillasNumbers_VillId",
                table: "VillasNumbers");

            migrationBuilder.DropColumn(
                name: "VillId",
                table: "VillasNumbers");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "VillasNumbers",
                newName: "UpdtedDate");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 9, 21, 19, 689, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 9, 21, 19, 689, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 9, 21, 19, 689, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 9, 21, 19, 689, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 9, 21, 19, 689, DateTimeKind.Local).AddTicks(1089));
        }
    }
}
