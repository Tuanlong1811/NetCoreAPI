using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTL.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_KhoHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoHang",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenSP = table.Column<string>(type: "TEXT", nullable: false),
                    GiaSP = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuongSP = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoHang", x => x.MaSP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhoHang");
        }
    }
}
