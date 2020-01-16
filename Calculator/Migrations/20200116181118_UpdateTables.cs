using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Loans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Term",
                table: "CertificateOfDeposits",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "DateCreated", "Name", "Type" },
                values: new object[] { "62a8842a-2feb-4330-8860-d1d0b28bcc5b", new DateTime(2020, 1, 16, 12, 11, 18, 210, DateTimeKind.Local).AddTicks(8425), "Nim Sum", "Normal" });

            migrationBuilder.InsertData(
                table: "CertificateOfDeposits",
                columns: new[] { "Id", "AccountNumber", "DateCreated", "InterestRate", "PortfolioId", "Term", "Type" },
                values: new object[] { "256b6fe3-917b-477d-bd4f-7b28a6f89fa2", 123456789, new DateTime(2020, 1, 16, 12, 11, 18, 214, DateTimeKind.Local).AddTicks(231), 5m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", 12, "Normal" });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "Id", "AccountNumber", "Balance", "DateCreated", "Income", "InterestRate", "PortfolioId", "Type", "UsageByPercentage" },
                values: new object[] { "3d09e3ac-6cb7-4079-9b31-d9f4ad1786f6", 123321123, 500m, new DateTime(2020, 1, 16, 12, 11, 18, 214, DateTimeKind.Local).AddTicks(3516), 1123m, 17m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", "Normal", 50m });

            migrationBuilder.InsertData(
                table: "Deposits",
                columns: new[] { "Id", "AccountNumber", "AverageBalance", "Cost", "DateCreated", "InterestRate", "PortfolioId", "Type" },
                values: new object[] { "74769c9e-0f23-4ee7-a542-a191081d4eea", 321321321, 5432m, 500m, new DateTime(2020, 1, 16, 12, 11, 18, 214, DateTimeKind.Local).AddTicks(7272), 0.32m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", "Normal" });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "AccountNumber", "Balance", "DateCreated", "Income", "InterestRate", "PortfolioId", "Term", "Type" },
                values: new object[] { "02b856f9-06bd-4d00-b7ec-2e88d3a7f730", 54323453, 9080m, new DateTime(2020, 1, 16, 12, 11, 18, 215, DateTimeKind.Local).AddTicks(620), 500m, 3.32m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", 48, "Car" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CertificateOfDeposits",
                keyColumn: "Id",
                keyValue: "256b6fe3-917b-477d-bd4f-7b28a6f89fa2");

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "Id",
                keyValue: "3d09e3ac-6cb7-4079-9b31-d9f4ad1786f6");

            migrationBuilder.DeleteData(
                table: "Deposits",
                keyColumn: "Id",
                keyValue: "74769c9e-0f23-4ee7-a542-a191081d4eea");

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: "02b856f9-06bd-4d00-b7ec-2e88d3a7f730");

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: "62a8842a-2feb-4330-8860-d1d0b28bcc5b");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "Term",
                table: "CertificateOfDeposits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
