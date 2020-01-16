using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificateOfDeposits",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Term = table.Column<string>(nullable: true),
                    InterestRate = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateOfDeposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificateOfDeposits_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    UsageByPercentage = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCards_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    AverageBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposits_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificateOfDeposits_PortfolioId",
                table: "CertificateOfDeposits",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_PortfolioId",
                table: "CreditCards",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_PortfolioId",
                table: "Deposits",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PortfolioId",
                table: "Loans",
                column: "PortfolioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateOfDeposits");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
