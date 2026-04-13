using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoaHoc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSV);
                });

            migrationBuilder.CreateTable(
                name: "DangKys",
                columns: table => new
                {
                    MaDK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKys", x => x.MaDK);
                    table.ForeignKey(
                        name: "FK_DangKys_KhoaHocs_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhoaHocs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKys_SinhViens_MaSV",
                        column: x => x.MaSV,
                        principalTable: "SinhViens",
                        principalColumn: "MaSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DangKys_MaKH",
                table: "DangKys",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_DangKys_MaSV",
                table: "DangKys",
                column: "MaSV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangKys");

            migrationBuilder.DropTable(
                name: "KhoaHocs");

            migrationBuilder.DropTable(
                name: "SinhViens");
        }
    }
}
