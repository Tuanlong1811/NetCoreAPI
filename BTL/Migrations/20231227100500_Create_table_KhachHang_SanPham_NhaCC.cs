using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTL.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_KhachHang_SanPham_NhaCC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhaCC",
                columns: table => new
                {
                    NhaCCID = table.Column<string>(type: "TEXT", nullable: false),
                    TenNhaCC = table.Column<string>(type: "TEXT", nullable: false),
                    TenSPCC = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuongCC = table.Column<int>(type: "INTEGER", nullable: false),
                    GiaThanh = table.Column<int>(type: "INTEGER", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCC", x => x.NhaCCID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhaCC");
        }
    }
}
