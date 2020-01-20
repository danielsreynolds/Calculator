using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator.Migrations
{
    public partial class DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificateOfDeposits_Portfolios_PortfolioId",
                table: "CertificateOfDeposits");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCards_Portfolios_PortfolioId",
                table: "CreditCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_Portfolios_PortfolioId",
                table: "Deposits");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Portfolios_PortfolioId",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Portfolios",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Portfolios",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Portfolios",
                maxLength: 280,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Loans",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "Loans",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Loans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Deposits",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "Deposits",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CreditCards",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "CreditCards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CertificateOfDeposits",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Term",
                table: "CertificateOfDeposits",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "CertificateOfDeposits",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "DateCreated", "Name", "Notes", "Type" },
                values: new object[] { "62a8842a-2feb-4330-8860-d1d0b28bcc5b", new DateTime(2020, 1, 20, 12, 22, 0, 49, DateTimeKind.Local).AddTicks(1917), "Nim Sum", null, "Normal" });

            migrationBuilder.InsertData(
                table: "CertificateOfDeposits",
                columns: new[] { "Id", "AccountNumber", "DateCreated", "InterestRate", "PortfolioId", "Term", "Type" },
                values: new object[] { "1a1cd8bc-7722-4800-adb9-8f44cba15e61", 123456789, new DateTime(2020, 1, 20, 12, 22, 0, 52, DateTimeKind.Local).AddTicks(4357), 5m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", 12, "Normal" });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "Id", "AccountNumber", "Balance", "DateCreated", "Income", "InterestRate", "PortfolioId", "Type", "UsageByPercentage" },
                values: new object[] { "e87f3a08-d430-49ab-97d1-75eb2b5f2c88", 123321123, 500m, new DateTime(2020, 1, 20, 12, 22, 0, 52, DateTimeKind.Local).AddTicks(7041), 1123m, 17m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", "Normal", 50m });

            migrationBuilder.InsertData(
                table: "Deposits",
                columns: new[] { "Id", "AccountNumber", "AverageBalance", "Cost", "DateCreated", "InterestRate", "PortfolioId", "Type" },
                values: new object[] { "fd665f7d-ac47-469e-9ec0-b37cc6b0602a", 321321321, 5432m, 500m, new DateTime(2020, 1, 20, 12, 22, 0, 52, DateTimeKind.Local).AddTicks(9298), 0.32m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", "Normal" });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "AccountNumber", "Balance", "DateCreated", "Income", "InterestRate", "PortfolioId", "Term", "Type" },
                values: new object[] { "7b88a90e-e340-4f18-8121-92e4f1d8a294", 54323453, 9080m, new DateTime(2020, 1, 20, 12, 22, 0, 53, DateTimeKind.Local).AddTicks(1155), 500m, 3.32m, "62a8842a-2feb-4330-8860-d1d0b28bcc5b", 48, "Car" });

            migrationBuilder.AddForeignKey(
                name: "FK_CertificateOfDeposits_Portfolios_PortfolioId",
                table: "CertificateOfDeposits",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCards_Portfolios_PortfolioId",
                table: "CreditCards",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Portfolios_PortfolioId",
                table: "Deposits",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Portfolios_PortfolioId",
                table: "Loans",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificateOfDeposits_Portfolios_PortfolioId",
                table: "CertificateOfDeposits");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCards_Portfolios_PortfolioId",
                table: "CreditCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_Portfolios_PortfolioId",
                table: "Deposits");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Portfolios_PortfolioId",
                table: "Loans");

            migrationBuilder.DeleteData(
                table: "CertificateOfDeposits",
                keyColumn: "Id",
                keyValue: "1a1cd8bc-7722-4800-adb9-8f44cba15e61");

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "Id",
                keyValue: "e87f3a08-d430-49ab-97d1-75eb2b5f2c88");

            migrationBuilder.DeleteData(
                table: "Deposits",
                keyColumn: "Id",
                keyValue: "fd665f7d-ac47-469e-9ec0-b37cc6b0602a");

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: "7b88a90e-e340-4f18-8121-92e4f1d8a294");

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: "62a8842a-2feb-4330-8860-d1d0b28bcc5b");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Deposits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "Deposits",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CreditCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "CreditCards",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CertificateOfDeposits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Term",
                table: "CertificateOfDeposits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PortfolioId",
                table: "CertificateOfDeposits",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_CertificateOfDeposits_Portfolios_PortfolioId",
                table: "CertificateOfDeposits",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCards_Portfolios_PortfolioId",
                table: "CreditCards",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Portfolios_PortfolioId",
                table: "Deposits",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Portfolios_PortfolioId",
                table: "Loans",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
