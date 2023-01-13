using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Address_AddressId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_AddressId",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Places");

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Walking = table.Column<int>(type: "int", nullable: false),
                    Cycling = table.Column<int>(type: "int", nullable: false),
                    PublicTransport = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NearestId = table.Column<int>(type: "int", nullable: false),
                    TimesId = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Category_Places_NearestId",
                        column: x => x.NearestId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category_Times_TimesId",
                        column: x => x.TimesId,
                        principalTable: "Times",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_AddressId",
                table: "Category",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_NearestId",
                table: "Category",
                column: "NearestId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_TimesId",
                table: "Category",
                column: "TimesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Places",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_AddressId",
                table: "Places",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Address_AddressId",
                table: "Places",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }
    }
}
