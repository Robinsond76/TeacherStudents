using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeacherStudents.Migrations
{
    public partial class InitialDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherId", "Age", "FirstName", "LastName" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 29, "Colt", "Steele" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherId", "Age", "FirstName", "LastName" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 34, "Brad", "Traversy" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "FirstName", "GPA", "LastName", "TeacherId" },
                values: new object[] { new Guid("9d1fed0f-0e53-4d7e-8b65-896fc8beccf2"), 23, "Bella", 3.6f, "Garnet", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870") });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "FirstName", "GPA", "LastName", "TeacherId" },
                values: new object[] { new Guid("f884a6ae-e1e6-483b-b7c6-804ad302c551"), 24, "Jenni", 3.7f, "Brewster", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870") });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "FirstName", "GPA", "LastName", "TeacherId" },
                values: new object[] { new Guid("6cbbd975-8f22-4d52-933d-42d387303626"), 27, "Sal", 3.1f, "Royce", new Guid("80abbca8-664d-4b20-b5de-024705497d4a") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("6cbbd975-8f22-4d52-933d-42d387303626"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9d1fed0f-0e53-4d7e-8b65-896fc8beccf2"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f884a6ae-e1e6-483b-b7c6-804ad302c551"));

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
