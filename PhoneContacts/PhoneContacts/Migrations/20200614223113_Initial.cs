using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneContacts.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PhoneNum = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.PhoneId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "PhoneId", "Address", "Name", "Notes", "PhoneNum" },
                values: new object[] { 4, "123 Main St", "Peter Pan", "Contact on Monday", 5155552314L });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "PhoneId", "Address", "Name", "Notes", "PhoneNum" },
                values: new object[] { 3, "555 Gingerbread Lane", "Jack Beanstalk", "Meet for Lunch", 5558675309L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
