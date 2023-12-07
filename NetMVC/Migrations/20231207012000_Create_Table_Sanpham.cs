using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Sanpham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khachhang",
                columns: table => new
                {
                    KhachhangID = table.Column<string>(type: "TEXT", nullable: false),
                    Tenkhachhang = table.Column<string>(type: "TEXT", nullable: false),
                    SDTkhachang = table.Column<int>(type: "INTEGER", nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.KhachhangID);
                });

            migrationBuilder.CreateTable(
                name: "Sanpham",
                columns: table => new
                {
                    SanphamID = table.Column<string>(type: "TEXT", nullable: false),
                    Tensanpham = table.Column<string>(type: "TEXT", nullable: false),
                    Thuonghieu = table.Column<int>(type: "INTEGER", nullable: false),
                    Soluong = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanpham", x => x.SanphamID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Khachhang");

            migrationBuilder.DropTable(
                name: "Sanpham");
        }
    }
}
