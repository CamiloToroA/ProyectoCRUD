using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCRUD.WEB.Migrations
{
    public partial class toro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Maquinas",
                type: "nvarchar(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Maquinas",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldNullable: true);
        }
    }
}
