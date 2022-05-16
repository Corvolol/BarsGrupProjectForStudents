using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class SomeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Users_UserEmail",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTag_Questions_QuestionsQuestionId",
                table: "QuestionTag");

            migrationBuilder.DropTable(
                name: "TagTeacher");

            migrationBuilder.DropColumn(
                name: "lesson",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Teachers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cafedra",
                table: "Teachers",
                newName: "Cafedra");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tags",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Reviews",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "review",
                table: "Reviews",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "QuestionsQuestionId",
                table: "QuestionTag",
                newName: "QuestionsId");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Questions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Answers",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "answer",
                table: "Answers",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Answers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Questions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TagTeacherModel",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    TeachersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagTeacherModel", x => new { x.TagsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_TagTeacherModel_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagTeacherModel_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TagTeacherModel_TeachersId",
                table: "TagTeacherModel",
                column: "TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Users_UserEmail",
                table: "Questions",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTag_Questions_QuestionsId",
                table: "QuestionTag",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Users_UserEmail",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTag_Questions_QuestionsId",
                table: "QuestionTag");

            migrationBuilder.DropTable(
                name: "TagTeacherModel");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teachers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Cafedra",
                table: "Teachers",
                newName: "cafedra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tags",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Reviews",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Reviews",
                newName: "review");

            migrationBuilder.RenameColumn(
                name: "QuestionsId",
                table: "QuestionTag",
                newName: "QuestionsQuestionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Questions",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Answers",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Answers",
                newName: "answer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Answers",
                newName: "AnswerId");

            migrationBuilder.AddColumn<string>(
                name: "lesson",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Questions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "TagTeacher",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    TeachersTeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagTeacher", x => new { x.TagsId, x.TeachersTeacherId });
                    table.ForeignKey(
                        name: "FK_TagTeacher_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagTeacher_Teachers_TeachersTeacherId",
                        column: x => x.TeachersTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TagTeacher_TeachersTeacherId",
                table: "TagTeacher",
                column: "TeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Users_UserEmail",
                table: "Questions",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTag_Questions_QuestionsQuestionId",
                table: "QuestionTag",
                column: "QuestionsQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
