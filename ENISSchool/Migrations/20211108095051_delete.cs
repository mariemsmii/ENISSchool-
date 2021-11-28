using Microsoft.EntityFrameworkCore.Migrations;

namespace ENISSchool.Migrations
{
    public partial class delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentEnis_Grade_GradeId",
                table: "StudentEnis");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentEnis_Grade_GradeId",
                table: "StudentEnis",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentEnis_Grade_GradeId",
                table: "StudentEnis");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentEnis_Grade_GradeId",
                table: "StudentEnis",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
