using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class PatronUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPatron_Books_BookId",
                table: "BookPatron");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPatron_Patrons_PatronId",
                table: "BookPatron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookPatron",
                table: "BookPatron");

            migrationBuilder.RenameTable(
                name: "BookPatron",
                newName: "BookPatrons");

            migrationBuilder.RenameIndex(
                name: "IX_BookPatron_PatronId",
                table: "BookPatrons",
                newName: "IX_BookPatrons_PatronId");

            migrationBuilder.RenameIndex(
                name: "IX_BookPatron_BookId",
                table: "BookPatrons",
                newName: "IX_BookPatrons_BookId");

            migrationBuilder.AddColumn<int>(
                name: "PatronId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookPatrons",
                table: "BookPatrons",
                column: "BookPatronId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PatronId",
                table: "Books",
                column: "PatronId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPatrons_Books_BookId",
                table: "BookPatrons",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPatrons_Patrons_PatronId",
                table: "BookPatrons",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Patrons_PatronId",
                table: "Books",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPatrons_Books_BookId",
                table: "BookPatrons");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPatrons_Patrons_PatronId",
                table: "BookPatrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Patrons_PatronId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PatronId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookPatrons",
                table: "BookPatrons");

            migrationBuilder.DropColumn(
                name: "PatronId",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "BookPatrons",
                newName: "BookPatron");

            migrationBuilder.RenameIndex(
                name: "IX_BookPatrons_PatronId",
                table: "BookPatron",
                newName: "IX_BookPatron_PatronId");

            migrationBuilder.RenameIndex(
                name: "IX_BookPatrons_BookId",
                table: "BookPatron",
                newName: "IX_BookPatron_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookPatron",
                table: "BookPatron",
                column: "BookPatronId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPatron_Books_BookId",
                table: "BookPatron",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPatron_Patrons_PatronId",
                table: "BookPatron",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
