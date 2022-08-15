using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EfExample.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "tbl_customers",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_positions",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_positions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_products",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employees",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    position_id = table.Column<int>(type: "integer", nullable: false),
                    salary = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_employees", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_employees_tbl_positions_position_id",
                        column: x => x.position_id,
                        principalSchema: "public",
                        principalTable: "tbl_positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_receipts",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: true),
                    employee_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_receipts", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_receipts_tbl_customers_customer_id",
                        column: x => x.customer_id,
                        principalSchema: "public",
                        principalTable: "tbl_customers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tbl_receipts_tbl_employees_employee_id",
                        column: x => x.employee_id,
                        principalSchema: "public",
                        principalTable: "tbl_employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_receipts_products",
                schema: "public",
                columns: table => new
                {
                    receipt_id = table.Column<int>(type: "integer", nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_receipts_products", x => new { x.product_id, x.receipt_id });
                    table.ForeignKey(
                        name: "FK_tbl_receipts_products_tbl_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "public",
                        principalTable: "tbl_products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_receipts_products_tbl_receipts_receipt_id",
                        column: x => x.receipt_id,
                        principalSchema: "public",
                        principalTable: "tbl_receipts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_employees_position_id",
                schema: "public",
                table: "tbl_employees",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_receipts_customer_id",
                schema: "public",
                table: "tbl_receipts",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_receipts_employee_id",
                schema: "public",
                table: "tbl_receipts",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_receipts_products_receipt_id",
                schema: "public",
                table: "tbl_receipts_products",
                column: "receipt_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_receipts_products",
                schema: "public");

            migrationBuilder.DropTable(
                name: "tbl_products",
                schema: "public");

            migrationBuilder.DropTable(
                name: "tbl_receipts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "tbl_customers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "tbl_employees",
                schema: "public");

            migrationBuilder.DropTable(
                name: "tbl_positions",
                schema: "public");
        }
    }
}
