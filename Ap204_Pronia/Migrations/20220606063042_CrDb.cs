using Microsoft.EntityFrameworkCore.Migrations;

namespace Ap204_Pronia.Migrations
{
    public partial class CrDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnotherSettings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnotherSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertisementImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasketIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WishListIcon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotherSettings", x => x.Id);
                });
        }
    }
}
