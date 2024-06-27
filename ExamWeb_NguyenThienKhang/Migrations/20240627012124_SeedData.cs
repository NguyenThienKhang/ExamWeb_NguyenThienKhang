using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenThienKhang.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "phims",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, "Khang", 100000.0, 100, true, "Chúng ta của 8 năm sau" },
                    { 2, "Duy", 200000.0, 110, false, "Gặp em ngày nắng" },
                    { 3, "Huân", 500000.0, 500, true, "Không ngạy cưới" },
                    { 4, "Phát", 900000.0, 120, false, "Gia đình đại chiến" },
                    { 5, "Nam", 700000.0, 250, true, "Tây du ký" },
                    { 6, "Thông", 600000.0, 100, true, "Gián điệp" },
                    { 7, "Tú", 105000.0, 100, true, "Cuộc chiến nhân tâm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
