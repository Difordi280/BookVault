using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookVault.Data.Migrations
{
    /// <inheritdoc />
    public partial class InicialLimpiaConSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Fantasía y Ficción" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Historia y Ciencia" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Clásicos Universales" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "IsDeleted", "IsSynced", "Isbn", "LastModified", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Gabriel García Márquez", new Guid("33333333-3333-3333-3333-333333333333"), false, false, "978-0307474728", new DateTime(2025, 12, 29, 16, 45, 5, 428, DateTimeKind.Local).AddTicks(6389), "Cien años de soledad" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Carlos Ruiz Zafón", new Guid("11111111-1111-1111-1111-111111111111"), false, false, "978-8408163381", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6247), "La sombra del viento" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Yuval Noah Harari", new Guid("22222222-2222-2222-2222-222222222222"), false, false, "978-8449330643", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6271), "Sapiens: De animales a dioses" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "F. Scott Fitzgerald", new Guid("33333333-3333-3333-3333-333333333333"), false, false, "978-0743273565", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6275), "The Great Gatsby" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "James Clear", new Guid("22222222-2222-2222-2222-222222222222"), false, false, "978-0735211292", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6278), "Atomic Habits" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "George Orwell", new Guid("11111111-1111-1111-1111-111111111111"), false, false, "978-0451524935", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6292), "1984" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Antoine de Saint-Exupéry", new Guid("33333333-3333-3333-3333-333333333333"), false, false, "978-2070612758", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6296), "Le Petit Prince" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Albert Camus", new Guid("33333333-3333-3333-3333-333333333333"), false, false, "978-2070360024", new DateTime(2025, 12, 29, 16, 45, 5, 431, DateTimeKind.Local).AddTicks(6299), "L'Étranger" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));
        }
    }
}
