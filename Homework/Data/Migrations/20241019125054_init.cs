using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Homeworks_HomeworkId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_HomeworkId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "HomeworkId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "BlackBoardId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BlackBoards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassroomId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true),
                    FilesPaths = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackBoards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlackBoards_ClassroomUsers_ClassroomId_AppUserId",
                        columns: x => new { x.ClassroomId, x.AppUserId },
                        principalTable: "ClassroomUsers",
                        principalColumns: new[] { "ClassroomId", "AppUserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlackBoardId",
                table: "Comments",
                column: "BlackBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_BlackBoards_ClassroomId_AppUserId",
                table: "BlackBoards",
                columns: new[] { "ClassroomId", "AppUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_BlackBoards_BlackBoardId",
                table: "Comments",
                column: "BlackBoardId",
                principalTable: "BlackBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_BlackBoards_BlackBoardId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "BlackBoards");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlackBoardId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BlackBoardId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "HomeworkId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClassroomId = table.Column<int>(type: "int", nullable: false),
                    FilesPaths = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_ClassroomUsers_ClassroomId_AppUserId",
                        columns: x => new { x.ClassroomId, x.AppUserId },
                        principalTable: "ClassroomUsers",
                        principalColumns: new[] { "ClassroomId", "AppUserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_HomeworkId",
                table: "Comments",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_ClassroomId_AppUserId",
                table: "Homeworks",
                columns: new[] { "ClassroomId", "AppUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Homeworks_HomeworkId",
                table: "Comments",
                column: "HomeworkId",
                principalTable: "Homeworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
