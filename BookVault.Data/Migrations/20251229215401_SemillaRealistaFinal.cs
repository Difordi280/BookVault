using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookVault.Data.Migrations
{
    /// <inheritdoc />
    public partial class SemillaRealistaFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "LastModified",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 428, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "LastModified",
                value: new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6299));
        }
    }
}
