using Microsoft.EntityFrameworkCore.Migrations;

namespace example1.Migrations
{
    public partial class InitialCreate
    {
        protected void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    IsLive = table.Column<bool>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.Id);
                });
        }
    }
}
