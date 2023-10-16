using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyMVC.Migrations
{
    /// <inheritdoc />
    public partial class RenamingProvider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Providers_ProviderId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "Medicines",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_ProviderId",
                table: "Medicines",
                newName: "IX_Medicines_SupplierId");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Suppliers_SupplierId",
                table: "Medicines",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Suppliers_SupplierId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Medicines",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_SupplierId",
                table: "Medicines",
                newName: "IX_Medicines_ProviderId");

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Providers_ProviderId",
                table: "Medicines",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id");
        }
    }
}
