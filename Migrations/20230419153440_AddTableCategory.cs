using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace List_To_Do.Migrations
{
    /// <inheritdoc />
    public partial class AddTableCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryIdId",
                table: "ToDo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_CategoryIdId",
                table: "ToDo",
                column: "CategoryIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDo_Category_CategoryIdId",
                table: "ToDo",
                column: "CategoryIdId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDo_Category_CategoryIdId",
                table: "ToDo");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_ToDo_CategoryIdId",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "CategoryIdId",
                table: "ToDo");
        }
    }
}
