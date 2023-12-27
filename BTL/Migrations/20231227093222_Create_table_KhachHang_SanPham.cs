using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTL.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_KhachHang_SanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenSP = table.Column<string>(type: "TEXT", nullable: false),
                    GiaSP = table.Column<int>(type: "INTEGER", nullable: false),
                    SoLuongSP = table.Column<int>(type: "INTEGER", nullable: false),
                    TinhTrangSP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
