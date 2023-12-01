using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.Migrations
{
    public partial class TeacherCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "AboutMe", "CreatedDate", "Degree", "Discriminator", "Experience", "FirstName", "ImagePath", "IsDeleted", "LastName", "SmallImagePath", "UpdatedDate" },
                values: new object[] { new Guid("a0e73cf8-9b1c-45f9-8e9c-d6f3c4111142"), "Her kese salam 33 yasim var", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Teacher", "4 year experience", "Qudret", "teacher-details.jpg", false, "Qudretov", "teacher1.jpg", null });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "AboutMe", "CreatedDate", "Degree", "Discriminator", "Experience", "FirstName", "ImagePath", "IsDeleted", "LastName", "SmallImagePath", "UpdatedDate" },
                values: new object[] { new Guid("d4aabd5c-0244-45ff-b4fd-9408ec44fcee"), "Her kese salam 35 yasim var", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Teacher", "4 year experience", "Esger", "teacher-details.jpg", false, "Letifov", "teacher10.jpg", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: new Guid("a0e73cf8-9b1c-45f9-8e9c-d6f3c4111142"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: new Guid("d4aabd5c-0244-45ff-b4fd-9408ec44fcee"));
        }
    }
}
