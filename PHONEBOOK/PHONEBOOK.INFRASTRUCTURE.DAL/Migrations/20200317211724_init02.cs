using Microsoft.EntityFrameworkCore.Migrations;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Migrations
{
    public partial class init02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PesronTags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personid = table.Column<int>(nullable: false),
                    tagid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesronTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PesronTags_tbl_Person_personid",
                        column: x => x.personid,
                        principalTable: "tbl_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PesronTags_Tags_tagid",
                        column: x => x.tagid,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypePhone = table.Column<int>(nullable: false),
                    phonenumber = table.Column<string>(nullable: false),
                    PersonID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Phones_tbl_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "tbl_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PesronTags_personid",
                table: "PesronTags",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_PesronTags_tagid",
                table: "PesronTags",
                column: "tagid");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_PersonID",
                table: "Phones",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PesronTags");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "tbl_Person");
        }
    }
}
